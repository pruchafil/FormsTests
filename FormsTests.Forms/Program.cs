using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Windows.Forms;
using FormsTests.Forms;

namespace FormsTests;

internal static class Program
{
    public static IServiceProvider ServiceProvider { get; private set; } = null!;

    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        var host = CreateHostBuilder().Build();
        ServiceProvider = host.Services;
        Application.Run(ServiceProvider.GetRequiredService<CurrentStationForm>());
    }

    static IHostBuilder CreateHostBuilder()
    {
        return Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) => {
                services.RegisterStorages();
                services.RegisterRepositories();
                services.AddTransient<CurrentStationForm>();
            });
    }
}