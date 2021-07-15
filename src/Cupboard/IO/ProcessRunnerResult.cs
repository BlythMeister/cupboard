﻿namespace Cupboard
{
    public sealed class ProcessRunnerResult
    {
        public int ExitCode { get; }
        public string StandardOut { get; }

        public ProcessRunnerResult(int exitCode, string? standardOut)
        {
            ExitCode = exitCode;
            StandardOut = standardOut ?? string.Empty;
        }
    }
}
