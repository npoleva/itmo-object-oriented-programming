using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressees;

public class CompositeAddressees : IAddressee
{
    private readonly ICollection<IAddressee> _addressees = new List<IAddressee>();

    public void ReceiveAndSendMessage(Message message)
    {
        foreach (IAddressee item in _addressees)
        {
            item.ReceiveAndSendMessage(message);
        }
    }

    public void AddAddressee(IAddressee addressee)
    {
        _addressees.Add(addressee);
    }

    public void RemoveAddressee(IAddressee addressee)
    {
        _addressees.Remove(addressee);
    }
}