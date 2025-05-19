using Itmo.ObjectOrientedProgramming.Lab3.MessageEndPoints;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressees;

public class UserAddressee : IAddressee
{
    private readonly IReceivable _messageEndPoint;
    public UserAddressee(IReceivable inputUser)
    {
        _messageEndPoint = inputUser;
    }

    public void ReceiveAndSendMessage(Message message)
    {
        _messageEndPoint.ReceiveMessageFromAddressee(message);
    }
}