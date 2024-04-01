using Microsoft.Extensions.DependencyInjection;
using Kurmann.Videoschnitt.MediaFileWatcher.Services;
using Microsoft.Extensions.Configuration;

namespace Kurmann.Videoschnitt.MediaFileWatcher;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddMediaFileWatcher(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        // Bindet Root-Konfigurationswerte an ModuleSettings
        services.Configure<ModuleSettings>(configuration.GetSection(ModuleSettings.SectionName));
        
        // Dienste hinzufügen
        services.AddHostedService<SampleHostedService>();
        
        return services;
    }
}
