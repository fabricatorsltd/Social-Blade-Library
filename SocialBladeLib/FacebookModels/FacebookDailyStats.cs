using System.Text.Json.Serialization;

namespace SocialBladeLib.FacebookModels;

public class FacebookDailyStats : FacebookStatisticsBase
{
    [JsonPropertyName("date")]
    public string? Date { get; set; }
}