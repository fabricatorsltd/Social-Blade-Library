using System.Text.Json.Serialization;

namespace SocialBladeLib.TikTokModels;

public class TikTokDailyStats : TikTokStatsBase
{
    [JsonPropertyName("date")]
    public string? Date { get; set; }
}