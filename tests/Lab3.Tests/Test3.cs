using System;
using Itmo.ObjectOrientedProgramming.Lab3.Addressees;
using Itmo.ObjectOrientedProgramming.Lab3.Addressees.Factory;
using Itmo.ObjectOrientedProgramming.Lab3.MessageEndPoints.Users;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.TopicDirectory;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;

public class Test3
{
    [Fact]
    public void ChangeMessageStatusFromNotReadToReadShouldThrowException()
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

        firstUser.ChangeMessageStatusFromNotReadToRead(firstMessage);

        Assert.Throws<InvalidOperationException>(() =>
            firstUser.ChangeMessageStatusFromNotReadToRead(firstMessage));
    }
}