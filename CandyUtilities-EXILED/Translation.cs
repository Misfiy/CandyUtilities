﻿namespace CandyUtilities_EXILED;

using Exiled.API.Interfaces;
using InventorySystem.Items.Usables.Scp330;
using System.ComponentModel;

public sealed class Translation : ITranslation
{
    [Description("The text shown when picking up a candy, note %type% gets replaced with the type of candy")]
    public string PickupText { get; set; } = "You take a piece of %type% candy.";
    [Description("Dictionary of candies and the respective text to show based on them")]
    public Dictionary<CandyKindID, string> CandyText { get; set; } = new()
    {
        { CandyKindID.Rainbow, "<color=#FF0000>R</color><color=#FF7F00>a</color><color=#FFFF00>i</color><color=#00FF00>n</color><color=#0000FF>b</color><color=#4B0082>o</color><color=#8A2BE2>w</color>" },
        { CandyKindID.Yellow, "<color=#FFFF00>Yellow</color>" },
        { CandyKindID.Purple, "<color=#800080>Purple</color>" },
        { CandyKindID.Red, "<color=#FF0000>Red</color>" },
        { CandyKindID.Green, "<color=#008000>Green</color>" },
        { CandyKindID.Blue, "<color=#0000FF>Blue</color>" },
        { CandyKindID.Pink, "<color=#FFC0CB>Pink</color>" },
        { CandyKindID.Orange, "<color=#ffa500>Orange</color>"},
        { CandyKindID.White, "<color=#ffffff>White</color>" },
        { CandyKindID.Gray, "<color=#808080>Gray</color>" },
        { CandyKindID.Black, "<color=#000000>Black</color>" },
        { CandyKindID.Brown, "<color=#644117>Brown</color>" },
        { CandyKindID.Evil, "Evil" }
    };
    [Description("Text to be shown when hands are being severed")] 
    public string SeveredText { get; set; } = "Hippity hoppity, your hands are now my property";
}