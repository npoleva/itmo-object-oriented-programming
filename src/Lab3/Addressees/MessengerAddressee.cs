using Itmo.ObjectOrientedProgramming.Lab3.MessageEndPoints;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressees;

public class MessengerAddressee : IAddressee
{
    private readonly IReceivable _messageEndPoint;
    public MessengerAddressee(IReceivable inputMessenger)
    {
        _messageEndPoint = inputMessenger;
    }

    public void ReceiveAndSendMessage(Message message)
    {
        _messageEndPoint.ReceiveMessageFromAddressee(message);
    }
}