using System.Text.Json.Serialization;

namespace SocialBladeLib.Models;

public class BrandingBase
{
    [JsonPropertyName("avatar")]
    public string? Avatar { get; set; }
}