using System;

static class LogLine
{
    public static string Message(string logLine)
    {

        int indexOfLogLevelEnd = logLine.IndexOf(":");
        int logLineLength = logLine.Length;
        int lengthOfLogMessage = logLineLength - indexOfLogLevelEnd;

        string logMessage = logLine.Substring(indexOfLogLevelEnd + 1).Trim();
        return logMessage;

    }


    public static string LogLevel(string logLine)
    {
        int openingBraceIndex = logLine.IndexOf("[");
        int closingBraceIndex = logLine.IndexOf("]");
        int lengthOfLogLevel = (closingBraceIndex - 1) - (openingBraceIndex);
        string logLevel = logLine.Substring((openingBraceIndex + 1), (lengthOfLogLevel)).ToLower();
        return logLevel;
    }
    public static string Reformat(string logLine)
    {
        string reformattedLogLine = $"{LogLine.Message(logLine)} ({LogLine.LogLevel(logLine)})";
        return reformattedLogLine;
    }
}
