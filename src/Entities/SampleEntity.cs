using CSharpFunctionalExtensions;

namespace Kurmann.AutomateVideoPublishing.MediaFileWatcher.Entities;

public class SampleEntity
{
    public string SampleParameter { get; }

    private SampleEntity(string sampleParameter)
    {
        SampleParameter = sampleParameter;
    }

    public static Result<SampleEntity> Create(string sampleParameter)
    {
        if (string.IsNullOrWhiteSpace(sampleParameter))
            return Result.Failure<SampleEntity>("Sample parameter cannot be empty");

        return Result.Success(new SampleEntity(sampleParameter));
    }
}