using System.Text.Json.Serialization;

namespace SocialBladeLib.TwitchModels;

public class TwitchGeneral
{
    [JsonPropertyName("geo")]
    public TwitchGeo? Geo { get; set; }
    
    [JsonPropertyName("branding ")]
    public TwitchBranding? Branding { get; set; }
}