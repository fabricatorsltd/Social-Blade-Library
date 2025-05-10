using System.Text.Json.Serialization;

namespace SocialBladeLib.InstagramModels;

public class InstagramStatisticsFull : InstagramStatisticsBase
{
    [JsonPropertyName("following")]
    public long? Following { get; set; }
    
    [JsonPropertyName("engagement_rate")]
    public double? EngadementRate { get; set; }
}