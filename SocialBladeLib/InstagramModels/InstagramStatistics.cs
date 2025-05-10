using System.Text.Json.Serialization;

namespace SocialBladeLib.InstagramModels;

public class InstagramStatistics
{
    [JsonPropertyName("total")]
    public InstagramStatisticsFull? Total { get; set; }
    
    [JsonPropertyName("growth")]
    public InstagramGrowth? Growth { get; set; }
}