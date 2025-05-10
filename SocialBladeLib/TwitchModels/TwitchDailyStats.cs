using System.Text.Json.Serialization;

namespace SocialBladeLib.TwitchModels;

public class TwitchDailyStats : TwitchStatisticsBase
{
    [JsonPropertyName("date")]
    public string? Date { get; set; }
}