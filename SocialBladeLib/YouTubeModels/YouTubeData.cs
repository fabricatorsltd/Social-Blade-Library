using System.Text.Json.Serialization;

namespace SocialBladeLib.YouTubeModels;

public class YouTubeData
{
    [JsonPropertyName("id")]
    public YouTubeId? Id { get; set; }
    
    [JsonPropertyName("general")]
    public YouTubeGeneral? General { get; set; }
    
    [JsonPropertyName("statistics")]
    public YouTubeStatistics? Statistics { get; set; }
    
    [JsonPropertyName("misc")]
    public YouTubeMisc? Misc { get; set; }
    
    [JsonPropertyName("ranks")]
    public YouTubeRanks? Ranks { get; set; }
    
    [JsonPropertyName("daily")]
    public IReadOnlyList<YouTubeDailyRecord>? Daily { get; set; }
    
}