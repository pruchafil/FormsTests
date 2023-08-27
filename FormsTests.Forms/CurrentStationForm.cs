using FormsTests.Data.Models;
using FormsTests.Data.Repositories;
using System.Windows.Forms;
using System.Linq;
using System;
using System.Threading.Tasks;

namespace FormsTests;

public partial class CurrentStationForm : Form
{
    private readonly ICurrentStationRepository _currentStationRepository;

    public CurrentStationForm(ICurrentStationRepository currentStationRepository)
    {
        _currentStationRepository = currentStationRepository;
        InitializeComponent();
        try
        {
            LoadData();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Load failed! {ex.Message}");
        }
    }
    private async Task SaveData()
    {
        CurrentStation currentStation = new CurrentStation();

        currentStation.TracksCount = (int)tracksCount.Value;
        currentStation.PlatformsCount = (int)platformsCount.Value;

        currentStation.SectorsCounts = sectorsCountsHolder.Controls
            .Cast<Control>()
            .Where(x => x.Name.Contains("sectorsCount"))
            .Select(x => (int)(x as NumericUpDown)!.Value)
            .ToArray();

        currentStation.SectorsStartingLabels =
            sectorsStartingLabelsHolder.Controls
            .Cast<Control>()
            .Where(x => x.Name.Contains("sectorsStartingLabel"))
            .Select(x => (x as TextBox)!.Text[0])
            .ToArray();

        currentStation.TracksLabels =
            trackLabelsHolder.Controls
            .Cast<Control>()
            .Where(x => x.Name.Contains("trackLabel"))
            .Select(x => (x as TextBox)!.Text)
            .ToArray();

        currentStation.PlatformsLabels =
            platformLabelsHolder.Controls
            .Cast<Control>()
            .Where(x => x.Name.Contains("platformLabel"))
            .Select(x => (x as TextBox)!.Text)
            .ToArray();

        currentStation.Station = (int)stationName.Value;

        foreach (var item in stationStructure.CheckedItems)
        {
            switch (item)
            {
                case "Podchod":
                    currentStation.Underpass = true;
                    break;
                case "Úrovòové pøechody":
                    currentStation.LevelTransitions = true;
                    break;
                case "Nadchod":
                    currentStation.Overpass = true;
                    break;
                case "Provizorní pøechod":
                    currentStation.TemporaryTransition = true;
                    break;
            }
        }

        await _currentStationRepository.UpdateCurrentStation(currentStation);
    }

    private void LoadData()
    {
        var station = _currentStationRepository.GetCurrentStation();
        tracksCount.Value = station.TracksCount;
        platformsCount.Value = station.PlatformsCount;

        for (int i = 0; i < station.TracksCount; i++)
        {
            var sectorsCount = new NumericUpDown
            {
                Value = station.SectorsCounts[i],
                Name = $"sectorsCount{i}"
            };
            var sectorsStartingLabel = new TextBox
            {
                Text = station.SectorsStartingLabels[i].ToString(),
                Name = $"sectorsStartingLabel{i}"
            };
            var trackLabel = new TextBox
            {
                Text = station.TracksLabels[i],
                Name = $"trackLabel{i}"
            };

            sectorsCountsHolder.Controls.Add(sectorsCount);
            sectorsStartingLabelsHolder.Controls.Add(sectorsStartingLabel);
            trackLabelsHolder.Controls.Add(trackLabel);

            sectorsStartingLabel.TextChanged += (sender, e) =>
            {
                sectorsStartingLabel.Text = sectorsStartingLabel.Text.Substring(0, 1).ToUpper();
            };
        }

        for (int i = 0; i < station.PlatformsCount; i++)
        {
            var platformLabel = new TextBox
            {
                Text = station.PlatformsLabels[i],
                Parent = platformLabelsHolder,
                Name = $"platformLabel{i}"
            };
            platformLabelsHolder.Controls.Add(platformLabel);
        }

        stationName.Value = station.Station;

        string[] arr = new string[4];
        stationStructure.Items.CopyTo(arr, 0);
        stationStructure.Items.Clear(); // copy and clear

        foreach (var item in arr) // to add it here with correct checked state
        {
            switch (item)
            {
                case "Podchod":
                    stationStructure.Items.Add(item, station.Underpass);
                    break;
                case "Úrovòové pøechody":
                    stationStructure.Items.Add(item, station.LevelTransitions);
                    break;
                case "Nadchod":
                    stationStructure.Items.Add(item, station.Overpass);
                    break;
                case "Provizorní pøechod":
                    stationStructure.Items.Add(item, station.TemporaryTransition);
                    break;
            }
        }
    }

    private async void Button_Save(object sender, EventArgs e)
    {
        await SaveData();
    }

    private void RegenerateTracks()
    {
        int controlsSize = sectorsCountsHolder.Controls.Count;
        for (int i = 0; i < controlsSize; i++)
        {
            var c1 = sectorsCountsHolder.Controls.Find($"sectorsCount{i}", true).First();
            var c2 = sectorsStartingLabelsHolder.Controls.Find($"sectorsStartingLabel{i}", true).First();
            var c3 = trackLabelsHolder.Controls.Find($"trackLabel{i}", true).First();
            sectorsCountsHolder.Controls.Remove(c1);
            sectorsStartingLabelsHolder.Controls.Remove(c2);
            trackLabelsHolder.Controls.Remove(c3);
            c1.Dispose();
            c2.Dispose();
            c3.Dispose();
        }

        int size = (int)tracksCount.Value;

        for (int i = 0; i < size; i++)
        {
            var sectorsCount = new NumericUpDown
            {
                Name = $"sectorsCount{i}"
            };
            var sectorsStartingLabel = new TextBox
            {
                Name = $"sectorsStartingLabel{i}"
            };
            var trackLabel = new TextBox
            {
                Name = $"trackLabel{i}"
            };

            sectorsStartingLabel.TextChanged += (sender, e) =>
            {
                sectorsStartingLabel.Text = sectorsStartingLabel.Text.Substring(0, 1).ToUpper();
            };

            sectorsCountsHolder.Controls.Add(sectorsCount);
            sectorsStartingLabelsHolder.Controls.Add(sectorsStartingLabel);
            trackLabelsHolder.Controls.Add(trackLabel);
        }

    }

    private void RegeneratePlatforms()
    {
        for (int i = 0; i < platformLabelsHolder.Controls.Count; i++)
        {
            var c = platformLabelsHolder.Controls.Find($"platformLabel{i}", true).First();
            platformLabelsHolder.Controls.Remove(c);
            c.Dispose();
        }

        int size = (int)platformsCount.Value;

        for (int i = 0; i < size; i++)
        {
            var platformLabel = new TextBox
            {
                Name = $"platformLabel{i}"
            };

            platformLabelsHolder.Controls.Add(platformLabel);
        }

    }

    private void TracksCountKeyDown(object sender, object e)
    {
        RegenerateTracks();
    }

    private void PlatformsCountKeyDown(object sender, object e)
    {
        RegeneratePlatforms();
    }
}
