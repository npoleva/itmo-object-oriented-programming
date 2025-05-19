using Itmo.ObjectOrientedProgramming.Lab4.FileSystem;

namespace Itmo.ObjectOrientedProgramming.Lab4.Application;

public interface IApplicationHandler
{
    public IApplicationHandler SetNext(IApplicationHandler successor);

    public abstract BaseFileSystem HandleRequest(string fileSystemMode);
}