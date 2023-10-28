using Microsoft.Extensions.DependencyInjection;
using PandorasBox.Service.Services;
using PandorasBox.Service.Services.Interfaces;

namespace PandorasBox;

public class Program
{
    public static void Main(string[] args)
    {
        var services = ConfigurationServices();

        App app = services.GetService<App>();

        app.Build();

        app.Run();
    }

    private static IServiceProvider ConfigurationServices()
    {
        var services = new ServiceCollection();

        DefineDependencies(services);

        return services.BuildServiceProvider();
    }

    private static void DefineDependencies(ServiceCollection services)
    {
        services.AddSingleton<App>();

        services.AddSingleton<SerialService>(new SerialService("COM5", 9600));

        services.AddScoped<IDashboardService, DashboardService>();
    }
}
