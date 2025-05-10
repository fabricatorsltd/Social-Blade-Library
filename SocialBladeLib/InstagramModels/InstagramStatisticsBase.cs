using System.Text.Json.Serialization;

namespace SocialBladeLib.InstagramModels;

public class InstagramStatisticsBase
{
    [JsonPropertyName("followers")]
    public long? Followers { get; set; }
    
    [JsonPropertyName("media")]
    public int? MediaCount { get; set; }
}