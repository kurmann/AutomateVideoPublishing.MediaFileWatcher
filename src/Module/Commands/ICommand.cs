using CSharpFunctionalExtensions;

namespace Kurmann.Videoschnitt.MediaFileWatcher.Commands;

public interface ICommand<T>
{
    Result<T> Execute();
}