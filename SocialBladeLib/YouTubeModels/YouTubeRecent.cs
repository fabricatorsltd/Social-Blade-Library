using System.Text.Json.Serialization;

namespace SocialBladeLib.YouTubeModels;

public class YouTubeRecent
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    
    [JsonPropertyName("time")]
    public string? Time { get; set; }
    
    [JsonPropertyName("type")]
    public string? Type { get; set; }
    
    [JsonPropertyName("post_url")]
    public string? PostUrl { get; set; }
}