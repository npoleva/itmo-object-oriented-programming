using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerComponentRecords;

public record FrameRecord : ComputerComponentRecord
{
    private readonly List<string> _supportedMotherBoardsFormPhactorsList;

    public FrameRecord(
        string frameName,
        IEnumerable<string> supportedMotherBoardFormFactors,
        double maximumVideoCardLength,
        double maximumVideoCardWidth)
    : base("Frame")
    {
        FrameName = frameName;
        _supportedMotherBoardsFormPhactorsList = new List<string>(supportedMotherBoardFormFactors);
        MaximumVideoCardLength = maximumVideoCardLength;
        MaximumVideoCardWidth = maximumVideoCardWidth;
    }

    public string FrameName { get; init; }
    public double MaximumVideoCardLength { get; init; }
    public double MaximumVideoCardWidth { get; init; }

    public IEnumerable<string> GetSupportedMotherBoardsPhormPhactorsList => _supportedMotherBoardsFormPhactorsList;
}