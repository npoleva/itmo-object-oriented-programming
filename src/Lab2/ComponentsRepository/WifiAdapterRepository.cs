using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerComponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComponentsRepository;

public class WifiAdapterRepository : IRepository<WifiAdapter>
{
    private readonly List<WifiAdapter> _components = new List<WifiAdapter>();

    private IEnumerable<WifiAdapter> Components => _components;

    public IEnumerable<WifiAdapter> GetComputerComponentsList()
    {
        return _components;
    }

    public WifiAdapter? GetComputerComponent(string id)
    {
        foreach (WifiAdapter item in Components)
        {
            if (item.WifiAdapterName == id) return item;
        }

        return null;
    }

    public void AddComputerComponent(WifiAdapter item)
    {
        _components.Add(item);
    }
}