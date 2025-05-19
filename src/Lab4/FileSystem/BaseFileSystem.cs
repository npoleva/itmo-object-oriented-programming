using System;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem;

public abstract class BaseFileSystem
{
    public bool IsConnected { get; protected set; }
    public string? FileSystemItemPath { get;  protected set; }
    public abstract bool IsValidPath(string path);

    public virtual void Connect(string address)
    {
        FileSystemItemPath = address;
        IsConnected = true;
    }

    public virtual void Disconnect()
    {
        IsConnected = false;
    }

    public virtual void EnsureConnected()
    {
        if (!IsConnected)
        {
            throw new InvalidOperationException("The file system is not connected.");
        }
    }

    public abstract void TreeGoTo(string newPath);
    public abstract void TreeList(int depth);
    public abstract void FileShow(IFilePrinter filePrinter);
    public abstract void FileMove(string sourcePath, string destinationPath);
    public abstract void FileCopy(string sourcePath, string destinationPath);
    public abstract void FileDelete(string path);
    public abstract void FileRename(string path, string name);
}