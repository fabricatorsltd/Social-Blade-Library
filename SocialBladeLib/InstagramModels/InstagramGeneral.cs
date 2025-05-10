using System.Text.Json.Serialization;

namespace SocialBladeLib.InstagramModels;

public class InstagramGeneral
{
    [JsonPropertyName("branding")]
    public InstagramBranding? Branding { get; set; }
    
    [JsonPropertyName("media")]
    public InstagramMediaObj? MediaObj { get; set; }
}