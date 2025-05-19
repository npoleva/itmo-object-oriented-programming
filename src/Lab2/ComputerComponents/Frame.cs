using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerComponents;

public class Frame : ComputerComponent
{
    private readonly List<string> _supportedMotherBoardsPhormPhactorsList;

    public Frame(
        string frameName,
        IEnumerable<string> supportedMotherBoardFormFactors,
        double maximumVideoCardLength,
        double maximumVideoCardWidth)
    : base("Frame")
    {
        FrameName = frameName;
        _supportedMotherBoardsPhormPhactorsList = new List<string>(supportedMotherBoardFormFactors);
        MaximumVideoCardLength = maximumVideoCardLength;
        MaximumVideoCardWidth = maximumVideoCardWidth;
    }

    public string FrameName { get; set; }
    public double MaximumVideoCardLength { get; private set; }
    public double MaximumVideoCardWidth { get; private set; }

    public IEnumerable<string> GetSupportedMotherBoardsPhormPhactorsList => _supportedMotherBoardsPhormPhactorsList;
}