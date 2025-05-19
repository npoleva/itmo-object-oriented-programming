using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressees.AdditionalFunctionality;

public class LoggerAddresseeProxy : IAddressee, ILogger
{
    private readonly IAddressee _concreteAddressee;
    private readonly ILogger _logger;
    public LoggerAddresseeProxy(IAddressee inputAddressee, ILogger logger)
    {
        _concreteAddressee = inputAddressee;
        _logger = logger;
    }

    public void ReceiveAndSendMessage(Message message)
    {
        _logger.Log(message);
        _concreteAddressee.ReceiveAndSendMessage(message);
    }

    public void Log(Message message)
    {
        _logger.Log(message);
    }
}