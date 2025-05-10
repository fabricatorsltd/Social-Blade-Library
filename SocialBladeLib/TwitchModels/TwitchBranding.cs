using System.Text.Json.Serialization;
using SocialBladeLib.Models;

namespace SocialBladeLib.TwitchModels;

public class TwitchBranding : BrandingBase
{
    [JsonPropertyName("banner")]
    public string? Banner { get; set; }
}