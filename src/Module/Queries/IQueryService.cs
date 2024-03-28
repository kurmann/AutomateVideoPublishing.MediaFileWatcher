using CSharpFunctionalExtensions;

namespace Kurmann.AutomateVideoPublishing.MediaFileWatcher.Queries;

public interface IQueryService<T>
{
    public Result<T> Execute();
}