using System.Text.Json.Serialization;
using SocialBladeLib.Models;

namespace SocialBladeLib.YouTubeModels;

public class YouTubeBranding : BrandingBase
{
    [JsonPropertyName("website")]
    public string? Website { get; set; }
}