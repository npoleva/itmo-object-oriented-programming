using System;
using System.IO;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem;

public class LocalFileSystem : BaseFileSystem
{
    public override bool IsValidPath(string path)
    {
        return Path.Exists(path);
    }

    public override void TreeGoTo(string newPath)
    {
        EnsureConnected();

        if (Path.IsPathFullyQualified(newPath))
        {
            FileSystemItemPath = newPath;
        }
        else
        {
            FileSystemItemPath += newPath;
        }
    }

    public override void TreeList(int depth)
    {
        string? pathRoot = Path.GetPathRoot(FileSystemItemPath);

        if (pathRoot == null) return;

        ITreePrinter printer = new LocalFileSystemTreePrinter();
        printer.PrintFileSystemTree(pathRoot, depth);
    }

    public override void FileShow(IFilePrinter filePrinter)
    {
        EnsureConnected();

        if (FileSystemItemPath != null)
            filePrinter?.ShowFile(FileSystemItemPath);
    }

    public override void FileMove(string sourcePath, string destinationPath)
    {
        EnsureConnected();

        sourcePath = Path.GetFullPath(sourcePath);
        destinationPath = Path.GetFullPath(destinationPath);

        try
        {
            File.Move(sourcePath, destinationPath);
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine($"Error moving the file. Unauthorized access: {ex.Message}");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Error moving the file: {ex.Message}");
        }
    }

    public override void FileCopy(string sourcePath, string destinationPath)
    {
        EnsureConnected();

        sourcePath = Path.GetFullPath(sourcePath);
        destinationPath = Path.GetFullPath(destinationPath);

        try
        {
            File.Copy(sourcePath, destinationPath);
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine($"Error moving the file. Unauthorized access: {ex.Message}");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Error moving the file: {ex.Message}");
        }
    }

    public override void FileDelete(string path)
    {
        EnsureConnected();

        path = Path.GetFullPath(path);

        try
        {
            if (File.Exists(path)) File.Delete(path);
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine($"Error deleting the file. Unauthorized access: {ex.Message}");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Error deleting the file: {ex.Message}");
        }
    }

    public override void FileRename(string path, string name)
    {
        EnsureConnected();
        path = Path.GetFullPath(path);
        string? directory = Path.GetDirectoryName(path);

        if (directory == null) return;
        string newFilePath = Path.Combine(directory, name);

        FileCopy(path, newFilePath);
        FileDelete(path);
    }
}