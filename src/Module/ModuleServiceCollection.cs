using Microsoft.Extensions.DependencyInjection;
using Kurmann.AutomateVideoPublishing.MediaFileWatcher.Services;

namespace Kurmann.AutomateVideoPublishing.MediaFileWatcher;

public static class ServiceCollection
{
    public static IServiceCollection AddMediaFileWatcher(this IServiceCollection services, ModuleSettings? moduleSettings)
    {
        if (moduleSettings != null)
        {
            services.AddSingleton(moduleSettings);

            services.AddHostedService<SampleHostedService>();
        }

        return services;
    }
}
