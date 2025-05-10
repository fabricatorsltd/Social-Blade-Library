using System.Text.Json.Serialization;
using SocialBladeLib.Models;

namespace SocialBladeLib.TwitchModels;

public class TwitchData
{
    [JsonPropertyName("id")]
    public IdBase? Id { get; set; }
    
    [JsonPropertyName("general")]
    public TwitchGeneral? General { get; set; }
    
    [JsonPropertyName("statistics")]
    public TwitchStatistics? Statistics { get; set; }
    
    [JsonPropertyName("misc")]
    public TwitchMisc? Misc { get; set; }
    
    [JsonPropertyName("ranks")]
    public TwitchRanks? Ranks { get; set; }
    
    [JsonPropertyName("daily")]
    public IReadOnlyList<TwitchDailyStats>? Daily { get; set; }
}