using System.Text.Json.Serialization;

namespace SocialBladeLib.InstagramModels;

public class InstagramDailyStats : InstagramStatisticsBase
{
    [JsonPropertyName("date")]
    public string? Date { get; set; }
    
    [JsonPropertyName("following")]
    public long? Following { get; set; }
    
    [JsonPropertyName("avg_likes")]
    public double? AvgLikes { get; set; }
    
    [JsonPropertyName("avg_comments")]
    public double? AvgComments { get; set; }
}