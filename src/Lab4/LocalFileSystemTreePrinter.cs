using System;
using System.IO;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class LocalFileSystemTreePrinter : ITreePrinter
{
    public void PrintFileSystemTree(string rootPath, int depth)
    {
        {
            if (depth < 0)
                return;
            Console.WriteLine(rootPath);
            PrintFileSystemNode(rootPath, " ", depth - 1);
        }
    }

    private void PrintFileSystemNode(string path, string indent, int depth)
    {
        if (depth < 0)
        {
            return;
        }

        try
        {
            foreach (string directory in Directory.EnumerateDirectories(path))
            {
                Console.WriteLine($"{indent}├── d: {Path.GetFileName(directory)}");
                PrintFileSystemNode(directory, indent + "│   ", depth - 1);
            }

            foreach (string file in Directory.EnumerateFiles(path))
            {
                Console.WriteLine($"{indent}├── f: {Path.GetFileName(file)}");
            }
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine($"{indent}│   ├── Mistake: {ex.Message}");
        }
    }
}