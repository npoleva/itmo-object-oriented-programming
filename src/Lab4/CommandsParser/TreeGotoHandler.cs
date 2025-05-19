using System;
using Itmo.ObjectOrientedProgramming.Lab4.FileCommands;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystem;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandsParser;

public class TreeGotoHandler : BaseCommandHandler
{
    public override void HandleRequest(string request, BaseFileSystem inputBaseFileSystem)
    {
        if (request == null) return;

        if (request.StartsWith("-tree goto", StringComparison.OrdinalIgnoreCase))
        {
            string[] parts = request.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (parts is [_, _, _])
            {
                string path = parts[2];
                ICommand treeGoToCommand =
                        new FileSystemTreeGoToCommand(inputBaseFileSystem, path);
                treeGoToCommand.Execute();
            }
        }
    }
}