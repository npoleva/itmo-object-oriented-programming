using System.IO;
using Crayon;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.MessageEndPoints.Displays;

public class Display : IReceivable
{
    private readonly DisplayDriver _concreteDisplayDriver;
    private readonly string _pathToOutputFile;
    public Display(string pathToOutputFile, DisplayDriver displayDriver)
    {
        _pathToOutputFile = pathToOutputFile;
        _concreteDisplayDriver = displayDriver;
    }

    public IOutput? MessageColor { get; private set; }
    public void ReceiveMessageFromAddressee(Message message)
    {
        Print(message);
    }

    public void Print(Message message)
    {
        File.WriteAllText(_pathToOutputFile, string.Empty);
        using var writer = new StreamWriter(_pathToOutputFile, true);

        writer.WriteLine(message?.MessageBody);

        if (message != null) _concreteDisplayDriver.Print(message);
    }
}