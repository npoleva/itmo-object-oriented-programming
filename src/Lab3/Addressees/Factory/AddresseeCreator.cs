using Itmo.ObjectOrientedProgramming.Lab3.MessageEndPoints;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressees.Factory;

public abstract class AddresseeCreator
{
    public abstract IAddressee CreateAddressee(IReceivable messageEndPoint);
}