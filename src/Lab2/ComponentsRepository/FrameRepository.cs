using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerComponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComponentsRepository;

public class FrameRepository : IRepository<Frame>
{
    private readonly List<Frame> _components = new List<Frame>();

    private IEnumerable<Frame> Components => _components;

    public IEnumerable<Frame> GetComputerComponentsList()
    {
        return _components;
    }

    public Frame? GetComputerComponent(string id)
    {
        foreach (Frame item in Components)
        {
            if (item.FrameName == id) return item;
        }

        return null;
    }

    public void AddComputerComponent(Frame item)
    {
        _components.Add(item);
    }
}