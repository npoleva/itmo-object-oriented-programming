using Itmo.ObjectOrientedProgramming.Lab4.FileSystem;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileCommands;

public class FileSystemFileShowCommand : ICommand
{
    private readonly BaseFileSystem _fileSystem;
    private readonly IFilePrinter _filePrinter;

    public FileSystemFileShowCommand(BaseFileSystem inputFileSystem, IFilePrinter inputFilePrinter)
    {
        _fileSystem = inputFileSystem;
        _filePrinter = inputFilePrinter;
    }

    public void Execute()
    {
        _fileSystem.FileShow(_filePrinter);
    }
}
