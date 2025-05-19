using System;
using Itmo.ObjectOrientedProgramming.Lab4.FileCommands;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystem;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandsParser;

public class ConnectHandler : BaseCommandHandler
{
    public override void HandleRequest(string request, BaseFileSystem inputBaseFileSystem)
    {
        if (request == null) return;

        if (request.StartsWith("-connect", StringComparison.OrdinalIgnoreCase))
        {
            string[] parts = request.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts is [_, _, "-m", _])
            {
                string address = parts[1];

                ICommand connectCommand = new FileSystemConnectCommand(inputBaseFileSystem, address);
                connectCommand.Execute();
                return;
            }
        }

        base.HandleRequest(request, inputBaseFileSystem);
    }
}