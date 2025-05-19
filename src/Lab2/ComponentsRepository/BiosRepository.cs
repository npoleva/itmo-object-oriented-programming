using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerComponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComponentsRepository;

public class BiosRepository : IRepository<Bios>
{
    private readonly List<Bios> _components = new List<Bios>();

    private IEnumerable<Bios> Components => _components;

    public IEnumerable<Bios> GetComputerComponentsList()
    {
        return _components;
    }

    public Bios? GetComputerComponent(string id)
    {
        foreach (Bios item in Components)
        {
            if (item.BiosName == id) return item;
        }

        return null;
    }

    public void AddComputerComponent(Bios item)
    {
        _components.Add(item);
    }
}