namespace Cupboard;

[PublicAPI]
public interface IProcessRunner
{
    Task<ProcessRunnerResult> Run(string file, string arguments, Func<string, bool>? filter = null, bool supressOutput = false);
}
