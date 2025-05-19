using Itmo.ObjectOrientedProgramming.Lab4.FileSystem;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileCommands;

public class FileSystemFileDeleteCommand : ICommand
{
    private readonly BaseFileSystem _fileSystem;
    private readonly string _path;

    public FileSystemFileDeleteCommand(
        BaseFileSystem inputFileSystem,
        string path)
    {
        _fileSystem = inputFileSystem;
        _path = path;
    }

    public void Execute()
    {
        _fileSystem.FileDelete(_path);
    }
}