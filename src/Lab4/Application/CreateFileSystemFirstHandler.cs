using Itmo.ObjectOrientedProgramming.Lab4.FileSystem;

namespace Itmo.ObjectOrientedProgramming.Lab4.Application;

public class CreateFileSystemFirstHandler : BaseApplicationHandler
{
    public override BaseFileSystem HandleRequest(string fileSystemMode)
    {
        if (fileSystemMode == "local")
        {
            return new LocalFileSystem();
        }

        return base.HandleRequest(fileSystemMode);
    }
}