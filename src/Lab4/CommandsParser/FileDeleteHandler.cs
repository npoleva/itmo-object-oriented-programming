using System;
using Itmo.ObjectOrientedProgramming.Lab4.FileCommands;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystem;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandsParser;

public class FileDeleteHandler : BaseCommandHandler
{
    public override void HandleRequest(string request, BaseFileSystem inputBaseFileSystem)
    {
        if (request == null) return;

        if (request.StartsWith("-file delete", StringComparison.OrdinalIgnoreCase))
        {
            string[] parts = request.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (parts is [_, _, _])
            {
                string path = parts[2];

                if (inputBaseFileSystem?.FileSystemItemPath == path)
                {
                    ICommand fileDeleteCommand =
                        new FileSystemFileDeleteCommand(
                            inputBaseFileSystem,
                            path);
                    fileDeleteCommand.Execute();
                }
                else
                {
                    throw new InvalidOperationException(
                        "The provided path does not match the current file system path.");
                }
            }
        }

        base.HandleRequest(request, inputBaseFileSystem);
    }
}