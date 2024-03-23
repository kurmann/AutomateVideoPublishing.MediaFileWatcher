using CSharpFunctionalExtensions;
using Kurmann.AutomateVideoPublishing.MediaFileWatcher.Entities;

namespace Kurmann.AutomateVideoPublishing.MediaFileWatcher.Module.Commands;

public class SampleCommand(string? sampleParameter) : ICommand<SampleEntity>
{
    private readonly string? sampleParameter = sampleParameter;

    public Result<SampleEntity> Execute()
    {
        if (string.IsNullOrWhiteSpace(sampleParameter))
            return Result.Failure<SampleEntity>("Sample parameter cannot be empty");
        
        var sampleEntity = SampleEntity.Create(sampleParameter);
        if (sampleEntity.IsFailure)
            return Result.Failure<SampleEntity>(sampleEntity.Error);

        return Result.Success(sampleEntity.Value);
    }
}
