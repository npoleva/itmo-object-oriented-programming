using Itmo.ObjectOrientedProgramming.Lab4.FileSystem;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileCommands;

public class FileSystemDisconnectCommand
{
    private readonly BaseFileSystem _fileSystem;

    public FileSystemDisconnectCommand(BaseFileSystem inputFileSystem)
    {
        _fileSystem = inputFileSystem;
    }

    public void Execute()
    {
        _fileSystem.Disconnect();
    }
}