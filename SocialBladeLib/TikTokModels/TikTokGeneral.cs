using System.Text.Json.Serialization;
using SocialBladeLib.Models;

namespace SocialBladeLib.TikTokModels;

public class TikTokGeneral
{
    [JsonPropertyName("branding")]
    public BrandingBase? Branding { get; set; }
}