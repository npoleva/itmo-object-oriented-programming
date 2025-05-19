using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerComponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComponentsRepository;

public class CpuCoolingSystemRepository : IRepository<CpuCoolingSystem>
{
    private readonly List<CpuCoolingSystem> _components = new List<CpuCoolingSystem>();

    private IEnumerable<CpuCoolingSystem> Components => _components;

    public IEnumerable<CpuCoolingSystem> GetComputerComponentsList()
    {
        return _components;
    }

    public CpuCoolingSystem? GetComputerComponent(string id)
    {
        foreach (CpuCoolingSystem item in Components)
        {
            if (item.CpuCoolingSystemName == id) return item;
        }

        return null;
    }

    public void AddComputerComponent(CpuCoolingSystem item)
    {
        _components.Add(item);
    }
}