using Itmo.ObjectOrientedProgramming.Lab3.MessageEndPoints;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressees.Factory;

public class DisplayAddresseeCreator : AddresseeCreator
{
    public override IAddressee CreateAddressee(IReceivable messageEndPoint)
    {
        return new DisplayAddressee(messageEndPoint);
    }
}