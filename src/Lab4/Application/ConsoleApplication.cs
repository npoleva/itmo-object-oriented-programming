using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab4.CommandsParser;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystem;

namespace Itmo.ObjectOrientedProgramming.Lab4.Application;

public class ConsoleApplication
{
    private readonly List<BaseFileSystem> _fileSystem = new List<BaseFileSystem>();
    private BaseFileSystem? _currentFileSystem;

    public void AddFileSystem(BaseFileSystem fileSystem)
    {
        _fileSystem.Add(fileSystem);
    }

    public void ReceiveRequest(string request)
    {
        if (request == null) return;

        if (request.StartsWith("-connect", StringComparison.OrdinalIgnoreCase))
        {
            string[] parts = request.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts is [_, _, "-m", _])
            {
                string mode = parts[3];
                var handler = new CreateFileSystemFirstHandler();

                _currentFileSystem = handler.HandleRequest(mode);
                AddFileSystem(_currentFileSystem);
            }
        }

        BaseCommandHandler handler1 = new ConnectHandler();
        BaseCommandHandler handler2 = new FileShowHandler();
        BaseCommandHandler handler3 = new DisconnectCommandHandler();
        BaseCommandHandler handler4 = new FileCopyHandler();
        BaseCommandHandler handler5 = new FileMoveHandler();
        BaseCommandHandler handler6 = new FileDeleteHandler();
        BaseCommandHandler handler7 = new FileRenameHandler();
        BaseCommandHandler handler8 = new TreeListHandler();
        BaseCommandHandler handler9 = new TreeGotoHandler();

        handler1.SetNext(handler2);
        handler2.SetNext(handler3);
        handler3.SetNext(handler4);
        handler4.SetNext(handler5);
        handler5.SetNext(handler6);
        handler6.SetNext(handler7);
        handler7.SetNext(handler8);
        handler8.SetNext(handler9);

        if (_currentFileSystem == null) return;

        handler1.HandleRequest(
                request,
                _currentFileSystem);
    }
}