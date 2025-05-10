using System.Text.Json.Serialization;

namespace SocialBladeLib.YouTubeModels;

public class YouTubeStatisticsTotal
{
    [JsonPropertyName("uploads")]
    public int Uploads { get; set; }
    
    [JsonPropertyName("subscribers")]
    public long Subscribers { get; set; }
    
    [JsonPropertyName("views")]
    public long Views { get; set; }
}