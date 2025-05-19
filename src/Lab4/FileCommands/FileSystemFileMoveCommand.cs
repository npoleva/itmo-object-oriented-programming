using Itmo.ObjectOrientedProgramming.Lab4.FileSystem;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileCommands;

public class FileSystemFileMoveCommand : ICommand
{
    private readonly BaseFileSystem _fileSystem;
    private readonly string _sourcePath;
    private readonly string _destinationPath;

    public FileSystemFileMoveCommand(
        BaseFileSystem inputFileSystem,
        string sourcePath,
        string destinationPath)
    {
        _fileSystem = inputFileSystem;
        _sourcePath = sourcePath;
        _destinationPath = destinationPath;
    }

    public void Execute()
    {
        _fileSystem.FileMove(_sourcePath, _destinationPath);
    }
}