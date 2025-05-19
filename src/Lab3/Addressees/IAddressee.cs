using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressees;

public interface IAddressee
{
    public void ReceiveAndSendMessage(Message message);
}