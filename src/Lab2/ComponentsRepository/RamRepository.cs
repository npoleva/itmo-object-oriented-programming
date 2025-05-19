using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerComponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComponentsRepository;

public class RamRepository : IRepository<Ram>
{
    private readonly List<Ram> _components = new List<Ram>();

    private IEnumerable<Ram> Components => _components;

    public IEnumerable<Ram> GetComputerComponentsList()
    {
        return _components;
    }

    public Ram? GetComputerComponent(string id)
    {
        foreach (Ram item in Components)
        {
            if (item.RamName == id) return item;
        }

        return null;
    }

    public void AddComputerComponent(Ram item)
    {
        _components.Add(item);
    }
}