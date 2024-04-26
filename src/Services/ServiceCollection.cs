using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Kurmann.Videoschnitt.MediaFileWatcher.Hosted;

namespace Kurmann.Videoschnitt.MediaFileWatcher;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddMediaFileWatcher(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        // Bindet Root-Konfigurationswerte an ServicesSettings
        services.Configure<ServicesSettings>(configuration.GetSection(ServicesSettings.SectionName));
        
        // Dienste hinzufügen
        services.AddHostedService<MediaFileWatcherService>();
        
        return services;
    }
}
