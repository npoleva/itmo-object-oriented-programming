using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerComponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComponentsRepository;

public class ComputerValidBuildRepository : IRepository<Computer>
{
    private readonly List<Computer> _computersList = new List<Computer>();

    private IEnumerable<Computer> ComputersList => _computersList;

    public IEnumerable<Computer> GetComputerComponentsList()
    {
        return _computersList;
    }

    public Computer? GetComputerComponent(string id)
    {
        foreach (Computer item in ComputersList)
        {
            if (item.ComputerName == id) return item;
        }

        return null;
    }

    public void AddComputerComponent(Computer item)
    {
        _computersList.Add(item);
    }
}