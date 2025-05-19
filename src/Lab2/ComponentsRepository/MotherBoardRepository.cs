using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerComponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComponentsRepository;

public class MotherBoardRepository : IRepository<MotherBoard>
{
    private readonly List<MotherBoard> _components = new List<MotherBoard>();

    private IEnumerable<MotherBoard> Components => _components;

    public IEnumerable<MotherBoard> GetComputerComponentsList()
    {
        return _components;
    }

    public MotherBoard? GetComputerComponent(string id)
    {
        foreach (MotherBoard item in Components)
        {
            if (item.MotherBoardName == id) return item;
        }

        return null;
    }

    public void AddComputerComponent(MotherBoard item)
    {
        _components.Add(item);
    }
}