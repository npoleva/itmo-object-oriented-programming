using Itmo.ObjectOrientedProgramming.Lab4.FileSystem;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandsParser;

public abstract class BaseCommandHandler : ICommandHandler
{
    private ICommandHandler? _nextSuccessor;

    public ICommandHandler SetNext(ICommandHandler successor)
    {
        _nextSuccessor = successor;

        return successor;
    }

    public virtual void HandleRequest(string request, BaseFileSystem inputBaseFileSystem)
    {
        _nextSuccessor?.HandleRequest(request, inputBaseFileSystem);
    }
}