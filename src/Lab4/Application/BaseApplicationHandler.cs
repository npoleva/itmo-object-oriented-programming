using System;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystem;

namespace Itmo.ObjectOrientedProgramming.Lab4.Application;

public class BaseApplicationHandler : IApplicationHandler
{
    private IApplicationHandler? _nextSuccessor;

    public IApplicationHandler SetNext(IApplicationHandler successor)
    {
        _nextSuccessor = successor;
        return successor;
    }

    public virtual BaseFileSystem HandleRequest(string fileSystemMode)
    {
        return _nextSuccessor?.HandleRequest(fileSystemMode) ?? throw new InvalidOperationException();
    }
}