using CSharpFunctionalExtensions;

namespace Kurmann.AutomateVideoPublishing.MediaFileWatcher.Module.Commands;

public interface ICommand<T>
{
    Result<T> Execute();
}