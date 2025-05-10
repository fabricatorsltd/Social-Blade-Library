using System.Text.Json.Serialization;

namespace SocialBladeLib.TwitchModels;

public class TwitchStatisticsBase
{
    [JsonPropertyName("followers")]
    public long? Followers { get; set; }
    
    [JsonPropertyName("views")]
    public long? Views { get; set; }
}