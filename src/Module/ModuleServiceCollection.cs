using Microsoft.Extensions.DependencyInjection;
using Kurmann.Videoschnitt.MediaFileWatcher.Services;

namespace Kurmann.Videoschnitt.MediaFileWatcher;

public static class ServiceCollection
{
    public static IServiceCollection AddMediaFileWatcher(this IServiceCollection services, ModuleSettings? moduleSettings)
    {
        if (moduleSettings != null)
        {
            services.AddSingleton(moduleSettings);

            services.AddHostedService<MediaFileWatcherService>();
        }

        return services;
    }
}
