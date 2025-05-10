using System.Text.Json.Serialization;

namespace SocialBladeLib.TikTokModels;

public class TikTokStatistics
{
    [JsonPropertyName("total")]
    public TikTokStatsBase? Total { get; set; }
}