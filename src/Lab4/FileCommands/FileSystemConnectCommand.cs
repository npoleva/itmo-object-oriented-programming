using Itmo.ObjectOrientedProgramming.Lab4.FileSystem;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileCommands;

public class FileSystemConnectCommand : ICommand
{
    private readonly BaseFileSystem _fileSystem;
    private readonly string _address;

    public FileSystemConnectCommand(BaseFileSystem inputFileSystem, string inputAddress)
    {
        _fileSystem = inputFileSystem;
        _address = inputAddress;
    }

    public void Execute()
    {
        _fileSystem.Connect(_address);
    }
}