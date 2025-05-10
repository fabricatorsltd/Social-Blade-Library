using System.Text.Json.Serialization;

namespace SocialBladeLib.YouTubeModels;

public class YouTubeGeneral
{
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; set; }
    
    [JsonPropertyName("channel_type")]
    public string? ChannelType { get; set; }
    
    [JsonPropertyName("geo")]
    public YouTubeGeo? Geo { get; set; }
    
    [JsonPropertyName("branding")]
    public YouTubeBranding? Branding { get; set; }
    
}