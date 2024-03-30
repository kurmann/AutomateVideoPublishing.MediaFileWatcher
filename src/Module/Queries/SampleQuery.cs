using CSharpFunctionalExtensions;

namespace Kurmann.AutomateVideoPublishing.MediaFileWatcher.Queries;

public class SampleQuery(string? sampleParameter) : IQueryService<SampleQueryResult>
{
    private readonly string? sampleParameter = sampleParameter;

    public Result<SampleQueryResult> Execute()
    {
        return Result.Success(new SampleQueryResult(sampleParameter));
    }
}

public record SampleQueryResult(string? SampleProperty);