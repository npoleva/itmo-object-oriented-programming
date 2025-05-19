using Itmo.ObjectOrientedProgramming.Lab4.FileSystem;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandsParser;

public interface ICommandHandler
{
    public ICommandHandler SetNext(ICommandHandler successor);

    public abstract void HandleRequest(string request, BaseFileSystem inputBaseFileSystem);
}