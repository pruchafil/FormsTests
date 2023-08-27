namespace FormsTests.Data.Models;

public class CurrentStation
{
    public int TracksCount { get; set; }
    public int PlatformsCount { get; set; }
    public int[] SectorsCounts { get; set; } = null!;
    public char[] SectorsStartingLabels { get; set; } = null!;
    public string[] TracksLabels { get; set; } = null!;
    public string[] PlatformsLabels { get; set; } = null!;
    public int Station { get; set; }
    public bool Underpass { get; set; }
    public bool LevelTransitions { get; set; }
    public bool Overpass { get; set; }
    public bool TemporaryTransition { get; set; }
}
