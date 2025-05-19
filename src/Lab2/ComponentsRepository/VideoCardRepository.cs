using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerComponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComponentsRepository;

public class VideoCardRepository : IRepository<VideoCard>
{
    private readonly List<VideoCard> _components = new List<VideoCard>();

    private IEnumerable<VideoCard> Components => _components;

    public IEnumerable<VideoCard> GetComputerComponentsList()
    {
        return _components;
    }

    public VideoCard? GetComputerComponent(string id)
    {
        foreach (VideoCard item in Components)
        {
            if (item.VideoCardName == id) return item;
        }

        return null;
    }

    public void AddComputerComponent(VideoCard item)
    {
        _components.Add(item);
    }
}