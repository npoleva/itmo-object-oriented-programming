using System;
using Itmo.ObjectOrientedProgramming.Lab4.FileCommands;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystem;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandsParser;

public class FileShowHandler : BaseCommandHandler
{
    public override void HandleRequest(string request, BaseFileSystem inputBaseFileSystem)
    {
        if (request == null) return;

        if (request.StartsWith("-file show", StringComparison.OrdinalIgnoreCase))
        {
            string[] parts = request.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (parts is [_, _, _, "-m", _])
            {
                string address = parts[2];
                string mode = parts[4];
                if (mode == "console")
                {
                    if (address == inputBaseFileSystem?.FileSystemItemPath)
                    {
                        IFilePrinter filePrinter = new ConsoleFilePrinter();

                        ICommand fileShowCommand =
                            new FileSystemFileShowCommand(inputBaseFileSystem, filePrinter);
                        fileShowCommand.Execute();
                        return;
                    }
                }
            }
        }

        if (inputBaseFileSystem != null) base.HandleRequest(request, inputBaseFileSystem);
    }
}