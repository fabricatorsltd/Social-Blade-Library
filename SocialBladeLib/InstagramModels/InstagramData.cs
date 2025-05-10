using System.Text.Json.Serialization;
using SocialBladeLib.Models;

namespace SocialBladeLib.InstagramModels;

public class InstagramData
{
    [JsonPropertyName("id")]
    public IdBase? Id { get; set; }
    
    [JsonPropertyName("general")]
    public InstagramGeneral? General { get; set; }
    
    [JsonPropertyName("statistics")]
    public InstagramStatistics? Statistics { get; set; }
    
    [JsonPropertyName("misc")]
    public MiscBase? Misc { get; set; }
    
    [JsonPropertyName("ranks")]
    public InstagramRanks? Ranks { get; set; }
    
    [JsonPropertyName("daily")]
    public IReadOnlyList<InstagramDailyStats>? Daily { get; set; }
}