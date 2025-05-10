using System.Text.Json.Serialization;
using SocialBladeLib.Models;

namespace SocialBladeLib.YouTubeModels;

public class YouTubeStatistics : StatisticsBase
{
    [JsonPropertyName("total")]
    public YouTubeStatisticsTotal? Total { get; set; }
    
    [JsonPropertyName("growth")]
    public YouTubeGrowth? Growth { get; set; }
}