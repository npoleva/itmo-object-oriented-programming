using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressees.AdditionalFunctionality;

public class FilterAddresseeProxy : IAddressee
{
    private readonly int _messageImportanceLevel;
    private readonly IAddressee _concreteAddressee;

    public FilterAddresseeProxy(IAddressee inputAddressee, int messageImportanceLevel)
    {
        _concreteAddressee = inputAddressee;
        _messageImportanceLevel = messageImportanceLevel;
    }

    public void ReceiveAndSendMessage(Message message)
    {
        if (Filtering(message))
            _concreteAddressee.ReceiveAndSendMessage(message);
    }

    private bool Filtering(Message? message)
    {
        return _messageImportanceLevel <= message?.ImportanceLevel;
    }
}