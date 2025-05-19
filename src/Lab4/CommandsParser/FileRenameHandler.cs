using System;
using Itmo.ObjectOrientedProgramming.Lab4.FileCommands;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystem;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandsParser;

public class FileRenameHandler : BaseCommandHandler
{
    public override void HandleRequest(string request, BaseFileSystem inputBaseFileSystem)
    {
        if (request == null) return;

        if (request.StartsWith("-file rename", StringComparison.OrdinalIgnoreCase))
        {
            string[] parts = request.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (parts is [_, _, _, _])
            {
                string path = parts[2];
                string name = parts[3];

                ICommand fileRenameCommand =
                        new FileSystemFileMoveCommand(
                            inputBaseFileSystem,
                            path,
                            name);
                fileRenameCommand.Execute();
            }
        }

        base.HandleRequest(request, inputBaseFileSystem);
    }
}