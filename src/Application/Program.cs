using Kurmann.Videoschnitt.MediaFileWatcher.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Kurmann.Videoschnitt.MediaFileWatcher.Application;

internal class Program
{
    static void Main(string[] args) => CreateHostBuilder(args).Build().Run();

    public static IHostBuilder CreateHostBuilder(string[] args)
    {
        var builder = Host.CreateDefaultBuilder(args);

        // Füge die Benutzergeheimnisse hinzu wenn in Development Umgebung
        if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == Environments.Development)
        {
            builder.ConfigureAppConfiguration((hostingContext, config) =>
            {
                config.AddUserSecrets<Program>();
            });
        }

        builder.ConfigureServices((hostContext, services) =>
        {
            services.Configure<ModuleSettings>(hostContext.Configuration);
            services.AddHostedService<MediaFileWatcherService>();
        });

        return builder;
    }
}