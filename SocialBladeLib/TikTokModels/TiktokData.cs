using System.Text.Json.Serialization;
using SocialBladeLib.Models;

namespace SocialBladeLib.TikTokModels;

public class TiktokData
{
    [JsonPropertyName("id")]
    public IdBase? Id { get; set; }
    
    [JsonPropertyName("general")]
    public TikTokGeneral? General { get; set; }
    
    [JsonPropertyName("statistics")]
    public TikTokStatistics? Statistics { get; set; }
    
    [JsonPropertyName("misc")]
    public MiscBase? Misc { get; set; }
    
    [JsonPropertyName("ranks")]
    public TikTokRanks? Ranks { get; set; }
    
    [JsonPropertyName("daily")]
    public IReadOnlyList<TikTokDailyStats>? Daily { get; set; }
}