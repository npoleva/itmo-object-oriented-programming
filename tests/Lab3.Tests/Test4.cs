using Itmo.ObjectOrientedProgramming.Lab3.Addressees;
using Itmo.ObjectOrientedProgramming.Lab3.Addressees.AdditionalFunctionality;
using Itmo.ObjectOrientedProgramming.Lab3.Addressees.Factory;
using Itmo.ObjectOrientedProgramming.Lab3.MessageEndPoints.Users;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.TopicDirectory;
using NSubstitute;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;

public class Test4
{
    [Fact]
    public void FilteringShouldNotSendMessageToAddressee()
    {
        User? firstUser = Substitute.For<User>("firstUser");

        var firstMessage = new Message(
            "Title of he first message",
            "Axel",
            1);

        AddresseeCreator addresseeCreator = Substitute.For<UserAddresseeCreator>();

        IAddressee firstUserAddressee = addresseeCreator.CreateAddressee(firstUser);

        FilterAddresseeProxy firstUserFilter = Substitute.For<FilterAddresseeProxy>(
            firstUserAddressee,
            3);

        var firstTopic = new Topic("TopicFirst", firstUserFilter, firstMessage);
        firstTopic.SendMessageToAddressee();

        firstUser.DidNotReceive().ReceiveMessageFromAddressee(firstMessage);
    }
}