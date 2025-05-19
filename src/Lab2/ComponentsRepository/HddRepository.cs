using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerComponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComponentsRepository;

public class HddRepository : IRepository<Hdd>
{
    private readonly List<Hdd> _components = new List<Hdd>();

    private IEnumerable<Hdd> Components => _components;

    public IEnumerable<Hdd> GetComputerComponentsList()
    {
        return _components;
    }

    public Hdd? GetComputerComponent(string id)
    {
        foreach (Hdd item in Components)
        {
            if (item.DriveName == id) return item;
        }

        return null;
    }

    public void AddComputerComponent(Hdd item)
    {
        _components.Add(item);
    }
}