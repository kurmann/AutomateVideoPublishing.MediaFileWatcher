using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Kurmann.AutomateVideoPublishing.MediaFileWatcher.Services;

public class MediaFileWatcherService(ILogger<MediaFileWatcherService> logger, IOptions<List<string>> watchDirectories) : IHostedService, IDisposable
{
    private readonly ILogger<MediaFileWatcherService> _logger = logger;
    private readonly IEnumerable<string> _watchDirectories = watchDirectories.Value;
    private FileSystemWatcher? _fileSystemWatcher;

    public Task StartAsync(CancellationToken cancellationToken)
    {
        // Logge Warnung, wenn keine Verzeichnisse zum Überwachen konfiguriert sind
        if (_watchDirectories == null || !_watchDirectories.Any())
        {
            _logger.LogWarning("No directories to watch are configured.");
            return Task.CompletedTask;
        }

        _logger.LogInformation("Media File Watcher Service is starting.");

        _fileSystemWatcher = new FileSystemWatcher
        {
            IncludeSubdirectories = true,
            NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName,
        };

        foreach (var directory in _watchDirectories)
        {
            _fileSystemWatcher.Path = directory;
            _fileSystemWatcher.Created += OnCreated;
            _fileSystemWatcher.Renamed += OnRenamed;
            _fileSystemWatcher.EnableRaisingEvents = true;
        }

        return Task.CompletedTask;
    }

    private void OnCreated(object sender, FileSystemEventArgs e)
    {
        _logger.LogInformation("File created: {file}", e.FullPath);
    }

    private void OnRenamed(object sender, RenamedEventArgs e)
    {
        _logger.LogInformation("File renamed: {file}", e.FullPath);
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Media File Watcher Service is stopping.");

        _fileSystemWatcher?.Dispose();

        return Task.CompletedTask;
    }

    public void Dispose()
    {
        _fileSystemWatcher?.Dispose();
        GC.SuppressFinalize(this);
    }
}