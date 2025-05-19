using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.MessageEndPoints;

public interface IReceivable
{
    public void ReceiveMessageFromAddressee(Message message);
}