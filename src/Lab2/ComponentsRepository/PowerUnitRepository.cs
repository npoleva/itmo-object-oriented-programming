using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerComponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComponentsRepository;

public class PowerUnitRepository : IRepository<PowerUnit>
{
    private readonly List<PowerUnit> _components = new List<PowerUnit>();

    private IEnumerable<PowerUnit> Components => _components;

    public IEnumerable<PowerUnit> GetComputerComponentsList()
    {
        return _components;
    }

    public PowerUnit? GetComputerComponent(string id)
    {
        foreach (PowerUnit item in Components)
        {
            if (item.PowerUnitName == id) return item;
        }

        return null;
    }

    public void AddComputerComponent(PowerUnit item)
    {
        _components.Add(item);
    }
}