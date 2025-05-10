using System.Text.Json.Serialization;
using SocialBladeLib.Models;

namespace SocialBladeLib.YouTubeModels;

public class YouTubeMisc : MiscBase
{
    [JsonPropertyName("made_for_kids")]
    public bool MadeForKids { get; set; }
}