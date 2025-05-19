using System;
using System.IO;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class ConsoleFilePrinter : IFilePrinter
{
    public void ShowFile(string path)
    {
        try
        {
            string content = File.ReadAllText(path);
            Console.WriteLine(content);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found.");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Error reading the file: {ex.Message}");
        }
    }
}