using Itmo.ObjectOrientedProgramming.Lab4.FileSystem;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileCommands;

public class FileSystemTreeGoToCommand : ICommand
{
    private readonly BaseFileSystem _fileSystem;
    private readonly string _newPath;

    public FileSystemTreeGoToCommand(BaseFileSystem inputFileSystem, string inputNewPath)
    {
        _fileSystem = inputFileSystem;
        _newPath = inputNewPath;
    }

    public void Execute()
    {
        _fileSystem.TreeGoTo(_newPath);
    }
}