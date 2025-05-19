using Itmo.ObjectOrientedProgramming.Lab3.Addressees;
using Itmo.ObjectOrientedProgramming.Lab3.Addressees.Factory;
using Itmo.ObjectOrientedProgramming.Lab3.MessageEndPoints.Users;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.TopicDirectory;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;

public class Test1
{
    [Fact]
    public void ReceiveMessageFromAddresseeShouldMakeMessageUnread()
    {
        var firstUser = new User("user");
        AddresseeCreator addresseeCreator = new UserAddresseeCreator();
        IAddressee firstUserAddressee = addresseeCreator.CreateAddressee(firstUser);

        var firstMessage = new Message(
            "Title of he first message",
            "Axel",
            1);

        var firstTopic = new Topic("TopicFirst", firstUserAddressee, firstMessage);
        firstTopic.SendMessageToAddressee();

        Assert.Equal(MessageStatusEnumeration.NotRead, firstUser.CheckMessageStatus(firstMessage));
    }
}