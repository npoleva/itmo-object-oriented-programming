using Itmo.ObjectOrientedProgramming.Lab4.FileSystem;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileCommands;

public class FileSystemTreeListCommand : ICommand
{
    private readonly BaseFileSystem _fileSystem;
    private readonly int _depth;

    public FileSystemTreeListCommand(BaseFileSystem inputFileSystem, int inputDepth)
    {
        _fileSystem = inputFileSystem;
        _depth = inputDepth;
    }

    public void Execute()
    {
        _fileSystem.TreeList(_depth);
    }
}