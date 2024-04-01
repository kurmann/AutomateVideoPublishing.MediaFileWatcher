using CSharpFunctionalExtensions;

namespace Kurmann.Videoschnitt.MediaFileWatcher.Queries;

public interface IQueryService<T>
{
    public Result<T> Execute();
}