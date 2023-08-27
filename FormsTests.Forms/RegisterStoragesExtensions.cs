using FormsTests.Data.FileSystem;
using FormsTests.Data.Models;
using Microsoft.Extensions.DependencyInjection;

namespace FormsTests.Forms;

public static class RegisterStoragesExtensions
{
    public static IServiceCollection RegisterStorages(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<ILocalStorage<CurrentStation>, CurrentStationStorage>();
        return serviceCollection;
    }
}
