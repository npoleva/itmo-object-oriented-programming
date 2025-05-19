using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.MessageEndPoints.Displays;

public abstract class DisplayDriver
{
    public abstract void Print(Message message);
}