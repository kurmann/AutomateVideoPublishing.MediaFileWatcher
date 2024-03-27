using CSharpFunctionalExtensions;

namespace Kurmann.AutomateVideoPublishing.MediaFileWatcher.Module.Commands;

public class SampleCommand(string? sampleParameter) : ICommand<SampleCommandResult>
{
    private readonly string? sampleParameter = sampleParameter;

    public Result<SampleCommandResult> Execute()
    {
        return Result.Success(new SampleCommandResult(sampleParameter));
    }
}

public record SampleCommandResult(string? SampleProperty);