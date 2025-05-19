using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerComponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComponentsRepository;

public class MemoryOverlookProfileRepository : IRepository<MemoryOverlookProfile>
{
    private readonly List<MemoryOverlookProfile> _components = new List<MemoryOverlookProfile>();

    private IEnumerable<MemoryOverlookProfile> Components => _components;

    public IEnumerable<MemoryOverlookProfile> GetComputerComponentsList()
    {
        return _components;
    }

    public MemoryOverlookProfile? GetComputerComponent(string id)
    {
        foreach (MemoryOverlookProfile item in Components)
        {
            if (item.MemoryOverlookProfileType == id) return item;
        }

        return null;
    }

    public void AddComputerComponent(MemoryOverlookProfile item)
    {
        _components.Add(item);
    }
}