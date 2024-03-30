using CSharpFunctionalExtensions;

namespace Kurmann.AutomateVideoPublishing.MediaFileWatcher.Commands;

public interface ICommand<T>
{
    Result<T> Execute();
}