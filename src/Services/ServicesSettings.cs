namespace Kurmann.Videoschnitt.MediaFileWatcher;

public class ServicesSettings
{
    public const string SectionName = "Kurmann.Videoschnitt.MediaFileWatcher";

    public string[] WatchDirectories { get; set; } = [];
}