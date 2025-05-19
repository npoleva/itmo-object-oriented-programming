using Itmo.ObjectOrientedProgramming.Lab3.Addressees;
using Itmo.ObjectOrientedProgramming.Lab3.Addressees.AdditionalFunctionality;
using Itmo.ObjectOrientedProgramming.Lab3.Addressees.Factory;
using Itmo.ObjectOrientedProgramming.Lab3.MessageEndPoints.Users;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.TopicDirectory;
using NSubstitute;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;

public class Test5
{
    [Fact]
    public void LogShouldLogWhenMessageReceived()
    {
        User? firstUser = Substitute.For<User>("firstUser");

        var firstMessage = new Message(
            "Title of he first message",
            "Axel",
            1);

        AddresseeCreator addresseeCreator = Substitute.For<UserAddresseeCreator>();

        IAddressee firstUserAddressee = addresseeCreator.CreateAddressee(firstUser);

        LoggerAddresseeProxy firstUserFilter = Substitute.For<LoggerAddresseeProxy>(
            firstUserAddressee,
            new FileLogger("C:\\Users\\lenovo\\RiderProjects\\npoleva\\src\\Lab3\\Addressees\\AdditionalFunctionality\\LogFile.txt"));

        var firstTopic = new Topic("TopicFirst", firstUserFilter, firstMessage);
        firstTopic.SendMessageToAddressee();

        firstUserFilter.Received().Log(firstMessage);
    }
}