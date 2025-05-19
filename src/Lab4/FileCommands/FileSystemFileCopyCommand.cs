using Itmo.ObjectOrientedProgramming.Lab4.FileSystem;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileCommands;

public class FileSystemFileCopyCommand : ICommand
{
    private readonly BaseFileSystem _fileSystem;
    private readonly string _sourcePath;
    private readonly string _destinationPath;

    public FileSystemFileCopyCommand(
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
        _fileSystem.FileCopy(_sourcePath, _destinationPath);
    }
}