using System;
using Itmo.ObjectOrientedProgramming.Lab4.FileCommands;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystem;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandsParser;

public class FileCopyHandler : BaseCommandHandler
{
    public override void HandleRequest(string request, BaseFileSystem inputBaseFileSystem)
    {
        if (request == null) return;

        if (request.StartsWith("-file copy", StringComparison.OrdinalIgnoreCase))
        {
            string[] parts = request.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (parts is [_, _, _, _])
            {
                string sourcePath = parts[2];
                string destinationPath = parts[3];

                ICommand fileCopyCommand =
                        new FileSystemFileCopyCommand(
                            inputBaseFileSystem,
                            sourcePath,
                            destinationPath);
                fileCopyCommand.Execute();
            }
        }

        base.HandleRequest(request, inputBaseFileSystem);
    }
}