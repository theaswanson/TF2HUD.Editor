﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Windows;
using Newtonsoft.Json.Linq;

namespace TF2HUD.Editor.JSON
{
    public class HudJson
    {
        [JsonPropertyName("Background")] public string Background;
        [JsonPropertyName("Controls")] public Dictionary<string, Controls[]> Controls;

        [JsonPropertyName("CustomizationsFolder")]
        public string CustomizationsFolder;

        [JsonPropertyName("EnabledFolder")] public string EnabledFolder;
        [JsonPropertyName("Layout")] public string[] Layout;
        [JsonPropertyName("Links")] public Links Links;
        [JsonPropertyName("Maximize")] public bool Maximize;
        [JsonPropertyName("Opacity")] public double Opacity = 0.5;
    }

    public class Links
    {
        [JsonPropertyName("Discord")] public string Discord;
        [JsonPropertyName("GitHub")] public string GitHub;
        [JsonPropertyName("HudsTF")] public string HudsTF;
        [JsonPropertyName("Issue")] public string Issue;
        [JsonPropertyName("Steam")] public string Steam;
        [JsonPropertyName("Update")] public string Update;
    }

    public class Controls
    {
        [JsonPropertyName("ComboFiles")] public string[] ComboFiles;

        public UIElement Control;
        [JsonPropertyName("FileName")] public string FileName;
        [JsonPropertyName("Files")] public JObject Files;
        [JsonPropertyName("Increment")] public int Increment = 2;
        [JsonPropertyName(";")] public string Label;
        [JsonPropertyName("Maximum")] public int Maximum = 30;
        [JsonPropertyName("Minimum")] public int Minimum = 10;
        [JsonPropertyName("Name")] public string Name;
        [JsonPropertyName("Options")] public Option[] Options;
        [JsonPropertyName("Pulse")] public bool Pulse;
        [JsonPropertyName("Special")] public string Special;
        [JsonPropertyName("Tooltip")] public string Tooltip;
        [JsonPropertyName("Type")] public string Type;
        [JsonPropertyName("Value")] public string Value = "0";
    }

    public class Option
    {
        [JsonPropertyName("FileName")] public string FileName;
        [JsonPropertyName("Files")] public JObject Files;
        [JsonPropertyName("Label")] public string Label;
        [JsonPropertyName("Special")] public string Special;
        [JsonPropertyName("Value")] public string Value;
    }
}