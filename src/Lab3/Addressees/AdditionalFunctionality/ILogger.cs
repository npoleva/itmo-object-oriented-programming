using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressees.AdditionalFunctionality;

public interface ILogger
{
    public void Log(Message message);
}