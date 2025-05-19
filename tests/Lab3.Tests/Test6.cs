using Itmo.ObjectOrientedProgramming.Lab3.Addressees;
using Itmo.ObjectOrientedProgramming.Lab3.Addressees.Factory;
using Itmo.ObjectOrientedProgramming.Lab3.MessageEndPoints.Messengers;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.TopicDirectory;
using NSubstitute;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;

public class Test6
{
    [Fact]
    public void ReceiveMessageFromAddresseeShouldPrintAndWriteReceivedMessage()
    {
        Messenger? firstMessenger = Substitute.For<Messenger>(
            @"C:\\Users\\lenovo\\RiderProjects\\npoleva\\src\\Lab3\\MessageEndPoints\\Messengers\\MessengerOutput.txt");

        var firstMessage = new Message(
            "Title of he first message",
            "Axel",
            1);

        AddresseeCreator addresseeCreator = Substitute.For<MessengerAddresseeCreator>();
        addresseeCreator.CreateAddressee(firstMessenger).Returns(new MessengerAddressee(firstMessenger));

        var firstTopic = new Topic("TopicFirst", addresseeCreator.CreateAddressee(firstMessenger), firstMessage);
        firstTopic.SendMessageToAddressee();

        firstMessenger.Received().Print(firstMessage);
        firstMessenger.Received().Write(firstMessage, firstMessenger.PathToOutputFile);
    }
}