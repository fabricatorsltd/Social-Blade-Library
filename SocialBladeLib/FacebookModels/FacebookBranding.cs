using System.Text.Json.Serialization;
using SocialBladeLib.Models;

namespace SocialBladeLib.FacebookModels;

public class FacebookBranding : BrandingBase
{
    [JsonPropertyName("banner")]
    public string? Banner { get; set; }
}