using CSharpFunctionalExtensions;

namespace Kurmann.AutomateVideoPublishing.MediaFileWatcher.Module.Queries;

public interface IQueryService<T>
{
    public Result<T> Execute();
}