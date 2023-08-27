using FormsTests.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace FormsTests.Forms;

public static class RegisterRepositoriesExtensions
{
    public static IServiceCollection RegisterRepositories(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<ICurrentStationRepository, CurrentStationRepository>();
        return serviceCollection;
    }
}
