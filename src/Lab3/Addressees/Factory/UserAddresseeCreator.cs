using Itmo.ObjectOrientedProgramming.Lab3.MessageEndPoints;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressees.Factory;

public class UserAddresseeCreator : AddresseeCreator
{
    public override IAddressee CreateAddressee(IReceivable messageEndPoint)
    {
        return new UserAddressee(messageEndPoint);
    }
}