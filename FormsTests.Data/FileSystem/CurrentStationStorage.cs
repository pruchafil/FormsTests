using FormsTests.Data.Models;
using System.Text.Json;
using System.IO;

namespace FormsTests.Data.FileSystem;

public class CurrentStationStorage : ILocalStorage<CurrentStation>
{
    private CurrentStation _data = null!;

    public string FilePath
    {
        get
        {
            return @"Soubory\Stanice\Současná.json";
        }
    }

    public CurrentStation Data
    {
        get
        {
            if (_data is null) // lazy initialization
            {
                LoadData();
            }

            return _data!;
        }
        set
        {
            _data = value;
        }
    }

    private void LoadData()
    {
        var station = JsonSerializer.Deserialize<CurrentStation>(File.ReadAllText(FilePath));

        if (station is null)
        {
            throw new JsonException($"Failed to convert data in {FilePath} into C# object.");
        }

        _data = station;
    }
}