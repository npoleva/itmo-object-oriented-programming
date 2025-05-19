using Itmo.ObjectOrientedProgramming.Lab4.FileSystem;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileCommands;

public class FileSystemFileRenameCommand : ICommand
{
    private readonly BaseFileSystem _fileSystem;
    private readonly string _path;
    private readonly string _name;

    public FileSystemFileRenameCommand(
        BaseFileSystem inputFileSystem,
        string path,
        string name)
    {
        _fileSystem = inputFileSystem;
        _path = path;
        _name = name;
    }

    public void Execute()
    {
        _fileSystem.FileRename(_path, _name);
    }
}