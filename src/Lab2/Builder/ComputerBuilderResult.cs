using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerComponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.Builder;

public record ComputerBuilderResult
{
    private List<MessagesEnumeration> _messages;
    public ComputerBuilderResult()
    {
        _messages = new List<MessagesEnumeration>();
    }

    public IEnumerable<MessagesEnumeration> Messages => _messages;
    public Outcome BuildingOutcome { get; set; }

    public Computer? BuildedComputer { get; set; }

    public void AddMessage(MessagesEnumeration message)
    {
        _messages.Add(message);
    }
}