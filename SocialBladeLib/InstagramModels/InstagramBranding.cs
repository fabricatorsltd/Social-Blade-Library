using System.Text.Json.Serialization;
using SocialBladeLib.Models;

namespace SocialBladeLib.InstagramModels;

public class InstagramBranding : BrandingBase
{
    [JsonPropertyName("website")]
    public string? Website { get; set; }
}