using Itmo.ObjectOrientedProgramming.Lab3.MessageEndPoints;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressees;

public class DisplayAddressee : IAddressee
{
    private readonly IReceivable _messageEndPoint;
    public DisplayAddressee(IReceivable inputDisplay)
    {
        _messageEndPoint = inputDisplay;
    }

    public void ReceiveAndSendMessage(Message message)
    {
        _messageEndPoint.ReceiveMessageFromAddressee(message);
    }
}