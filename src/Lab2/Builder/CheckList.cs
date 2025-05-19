using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.Builder;

public static class CheckList
{
    public static IEnumerable<string> GetComponentOrderCheckList => ComponentOrderChecklist;
    private static List<string> ComponentOrderChecklist { get; set; } = new List<string>
    {
        "Motherboard",
        "BIOS",
        "CPU",
        "RAM",
        "Memory Overlook Profile",
        "CPU Cooling System",
        "Video card",
        "Frame",
        "HDD",
        "SSD",
        "Power Unit",
    };

    public static void ChangeCheckList(IEnumerable<string> newInputCheckList)
    {
        ComponentOrderChecklist = new List<string>(newInputCheckList);
    }
}