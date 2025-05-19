using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.MessageEndPoints.Users;

public class UserSideMessage
{
    public UserSideMessage(Message inputMessage)
    {
        InputMessage = inputMessage;
    }

    public Message InputMessage { get; private set; }
    public MessageStatusEnumeration MessageStatus { get; set; } = MessageStatusEnumeration.NotRead;
}