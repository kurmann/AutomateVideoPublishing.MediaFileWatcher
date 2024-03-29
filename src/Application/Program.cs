using Kurmann.AutomateVideoPublishing.MediaFileWatcher.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Kurmann.AutomateVideoPublishing.MediaFileWatcher.Application;

internal class Program
{
    static void Main(string[] args) => CreateHostBuilder(args).Build().Run();

    public static IHostBuilder CreateHostBuilder(string[] args)
    {
        return Host.CreateDefaultBuilder(args)
            .ConfigureServices((hostContext, services) =>
            {
                services.Configure<ModuleSettings>(hostContext.Configuration.GetSection("ModuleSettings"));
                services.AddHostedService<MediaFileWatcherService>();
            });
    }
}