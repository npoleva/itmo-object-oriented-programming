namespace Itmo.ObjectOrientedProgramming.Lab3.Messages;

public class Message
{
    public Message(
        string title,
        string messageBody,
        int importanceLevel)
    {
        Title = title;
        MessageBody = messageBody;
        ImportanceLevel = importanceLevel;
    }

    public string Title { get; private set; }
    public string MessageBody { get; private set; }
    public int ImportanceLevel { get; private set; }
}