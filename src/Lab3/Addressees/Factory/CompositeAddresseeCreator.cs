using Itmo.ObjectOrientedProgramming.Lab3.MessageEndPoints;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressees.Factory;

public class CompositeAddresseeCreator : AddresseeCreator
{
    public override IAddressee CreateAddressee(IReceivable messageEndPoint)
    {
        return new CompositeAddressees();
    }
}