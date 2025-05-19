using System;
using Itmo.ObjectOrientedProgramming.Lab4.FileCommands;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystem;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandsParser;

public class DisconnectCommandHandler : BaseCommandHandler
{
    public override void HandleRequest(string request, BaseFileSystem inputBaseFileSystem)
    {
        if (request == null) return;

        if (request.StartsWith("-disconnect", StringComparison.OrdinalIgnoreCase))
        {
            var connectCommand = new FileSystemDisconnectCommand((LocalFileSystem)inputBaseFileSystem);
            connectCommand.Execute();
        }
    }
}