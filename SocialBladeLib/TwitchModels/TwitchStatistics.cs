using System.Text.Json.Serialization;

namespace SocialBladeLib.TwitchModels;

public class TwitchStatistics
{
    [JsonPropertyName("total")]
    public TwitchStatisticsBase? Total { get; set; }
    
    [JsonPropertyName("growth")]
    public TwitchGrowth? Growth { get; set; }
}