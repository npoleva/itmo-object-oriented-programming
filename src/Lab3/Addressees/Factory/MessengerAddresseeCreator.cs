using Itmo.ObjectOrientedProgramming.Lab3.MessageEndPoints;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressees.Factory;

public class MessengerAddresseeCreator : AddresseeCreator
{
    public override IAddressee CreateAddressee(IReceivable messageEndPoint)
    {
        return new MessengerAddressee(messageEndPoint);
    }
}