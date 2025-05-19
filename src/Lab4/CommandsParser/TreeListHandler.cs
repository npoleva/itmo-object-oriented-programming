using System;
using Itmo.ObjectOrientedProgramming.Lab4.FileCommands;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystem;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandsParser;

public class TreeListHandler : BaseCommandHandler
{
    public override void HandleRequest(string request, BaseFileSystem inputBaseFileSystem)
    {
        if (request == null) return;

        if (request.StartsWith("-tree list", StringComparison.OrdinalIgnoreCase))
        {
            string[] parts = request.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (parts is [_, _, "-d", _])
            {
                string depth = parts[3];
                int depthValue = 0;

                if (int.TryParse(depth, out int depthValueParse))
                {
                    depthValue = depthValueParse;
                }

                ICommand treeListCommand = new FileSystemTreeListCommand(inputBaseFileSystem, depthValue);
                treeListCommand.Execute();
            }
        }

        base.HandleRequest(request, inputBaseFileSystem);
    }
}