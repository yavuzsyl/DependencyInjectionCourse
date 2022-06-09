﻿namespace Weather.Api.Logging;

public interface ILoggerAdapter<TType>
{
    void Log(LogLevel logLevel, string template, params object[] args);

    void LogInformation(string template, params object[] args);
}
