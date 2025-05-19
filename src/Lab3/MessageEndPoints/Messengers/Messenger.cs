using System;
using System.IO;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.MessageEndPoints.Messengers;

public class Messenger : IPrintable, IWritable, IReceivable
{
    public Messenger(string pathToOutputFile)
    {
        PathToOutputFile = pathToOutputFile;
    }

    public string PathToOutputFile { get; }
    public void ReceiveMessageFromAddressee(Message message)
    {
        Print(message);
        Write(message, PathToOutputFile);
    }

    public void Print(Message message)
    {
        Console.WriteLine("Messenger: " + message?.MessageBody);
    }

    public void Write(Message message, string path)
    {
        using var writer = new StreamWriter(path, true);
        writer.WriteLine("Messenger: " + message?.MessageBody);
    }
}