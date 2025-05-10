using System.Text.Json.Serialization;

namespace SocialBladeLib.TwitchModels;

public class TwitchRecent
{
    [JsonPropertyName("game")]
    public string? Game { get; set; }
    
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}