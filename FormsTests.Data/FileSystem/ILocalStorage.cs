using System.Text.Json;
using System.IO;
using System.Threading.Tasks;
using System.Text;
using System.Linq;

namespace FormsTests.Data.FileSystem;

public interface ILocalStorage<T>
{
    public string FilePath { get; }
    public T Data { get; set; }
    public async Task SaveChangesAsync()
    {
        var task = Task.Run(() => JsonSerializer.Serialize(Data, new JsonSerializerOptions()
        {
            WriteIndented = true
        }));

        var result = await task;

        var sb = new StringBuilder();
        var dirs = FilePath.Split('\\').SkipLast(1); // ends with is \file.json, so we skip that

        foreach (var item in dirs)
        {
            sb.Append(item);

            var dirToCheck = sb.ToString();

            if (!Directory.Exists(dirToCheck))
            {
                Directory.CreateDirectory(dirToCheck);
            }
            sb.Append('\\');
        }

        await File.WriteAllTextAsync(FilePath, result);
    }
}
