using System;
using Crayon;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.MessageEndPoints.Displays;

public class DisplayDriverWithColorfulOutput : DisplayDriver
{
    private readonly IOutput _color;
    public DisplayDriverWithColorfulOutput(IOutput color)
    {
        _color = color;
    }

    public override void Print(Message message)
    {
        Console.Clear();

        Console.WriteLine(message?.MessageBody);

        if (message?.MessageBody != null)
            Console.WriteLine(_color.Text(message.MessageBody));
    }
}