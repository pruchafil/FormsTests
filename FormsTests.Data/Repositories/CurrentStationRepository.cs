using FormsTests.Data.FileSystem;
using FormsTests.Data.Models;
using System.Threading.Tasks;

namespace FormsTests.Data.Repositories;

public interface ICurrentStationRepository
{
    public CurrentStation GetCurrentStation();
    public Task UpdateCurrentStation(CurrentStation currentStation);
}

public class CurrentStationRepository : ICurrentStationRepository
{
    private readonly ILocalStorage<CurrentStation> _currentStationStorage;

    public CurrentStationRepository(ILocalStorage<CurrentStation> currentStationStorage)
    {
        _currentStationStorage = currentStationStorage;
    }

    public CurrentStation GetCurrentStation()
    {
        return _currentStationStorage.Data;
    }

    public async Task UpdateCurrentStation(CurrentStation currentStation)
    {
        _currentStationStorage.Data = currentStation;
        await _currentStationStorage.SaveChangesAsync();
    }
}