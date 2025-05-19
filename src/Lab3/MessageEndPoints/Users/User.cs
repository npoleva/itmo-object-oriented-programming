using System;
using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.MessageEndPoints.Users;

public class User : IReceivable
{
    private readonly List<UserSideMessage> _messages = new();
    private readonly string _userName;

    public User(string userName)
    {
        _userName = userName;
    }

    private IEnumerable<UserSideMessage> Messages => _messages;

    public void ReceiveMessageFromAddressee(Message message)
    {
        _messages.Add(new UserSideMessage(message));
    }

    public void ChangeMessageStatusFromNotReadToRead(Message message)
    {
        UserSideMessage? userSideMessage = Messages.FirstOrDefault(tmp => tmp.InputMessage == message);

        if (userSideMessage is { MessageStatus: MessageStatusEnumeration.NotRead })
        {
            userSideMessage.MessageStatus = MessageStatusEnumeration.Read;
        }
        else
        {
            throw new InvalidOperationException("Message status is already 'Read!'\n");
        }
    }

    public MessageStatusEnumeration CheckMessageStatus(Message message)
    {
        UserSideMessage tmp = Messages.FirstOrDefault(v => v.InputMessage == message)
                              ?? throw new InvalidOperationException("Message not found");
        return tmp.MessageStatus;
    }
}