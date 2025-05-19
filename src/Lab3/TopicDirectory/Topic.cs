using Itmo.ObjectOrientedProgramming.Lab3.Addressees;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.TopicDirectory;

public class Topic
{
    public Topic(string topicName, IAddressee topicAddressee, Message inputMessage)
    {
        TopicName = topicName;
        TopicAddressee = topicAddressee;
        InputMessage = inputMessage;
    }

    public string TopicName { get; private set; }
    private IAddressee TopicAddressee { get; set; }
    private Message InputMessage { get; set; }

    public void SendMessageToAddressee()
    {
        TopicAddressee.ReceiveAndSendMessage(InputMessage);
    }
}