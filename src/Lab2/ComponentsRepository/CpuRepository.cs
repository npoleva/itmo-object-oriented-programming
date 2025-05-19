using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerComponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComponentsRepository;

public class CpuRepository : IRepository<Cpu>
{
    private readonly List<Cpu> _components = new List<Cpu>();

    private IEnumerable<Cpu> Components => _components;

    public IEnumerable<Cpu> GetComputerComponentsList()
    {
        return _components;
    }

    public Cpu? GetComputerComponent(string id)
    {
        foreach (Cpu item in Components)
        {
            if (item.CpuName == id) return item;
        }

        return null;
    }

    public void AddComputerComponent(Cpu item)
    {
        _components.Add(item);
    }
}