using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerComponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComponentsRepository;

public class SsdDriveRepository : IRepository<SsdDrive>
{
    private readonly List<SsdDrive> _components = new List<SsdDrive>();

    private IEnumerable<SsdDrive> Components => _components;

    public IEnumerable<SsdDrive> GetComputerComponentsList()
    {
        return _components;
    }

    public SsdDrive? GetComputerComponent(string id)
    {
        foreach (SsdDrive item in Components)
        {
            if (item.DriveName == id) return item;
        }

        return null;
    }

    public void AddComputerComponent(SsdDrive item)
    {
        _components.Add(item);
    }
}