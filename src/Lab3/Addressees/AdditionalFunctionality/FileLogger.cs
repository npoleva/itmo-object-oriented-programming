using System.IO;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressees.AdditionalFunctionality;

public class FileLogger : ILogger
{
    private readonly string _pathToLogFile;

    public FileLogger(string path)
    {
        _pathToLogFile = path;
    }

    public void Log(Message message)
    {
        using var writer = new StreamWriter(_pathToLogFile, true);

        writer.WriteLine($"Message received: {message?.MessageBody}\n");
    }
}