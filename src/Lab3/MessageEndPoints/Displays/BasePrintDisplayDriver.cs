using System;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.MessageEndPoints.Displays;

public class BasePrintDisplayDriver : DisplayDriver
{
    public override void Print(Message message)
    {
        Console.Clear();

        Console.WriteLine(message?.MessageBody);
    }
}