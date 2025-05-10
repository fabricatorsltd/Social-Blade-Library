using System.Text.Json.Serialization;

namespace SocialBladeLib.FacebookModels;

public class FacebookStatistics
{
    [JsonPropertyName("total")]
    public FacebookStatisticsBase? Total { get; set; }
    
    [JsonPropertyName("growth")]
    public FacebookGrowth? Growth { get; set; }
}