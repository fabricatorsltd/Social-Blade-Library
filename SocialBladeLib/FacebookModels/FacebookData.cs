using System.Text.Json.Serialization;
using SocialBladeLib.Models;

namespace SocialBladeLib.FacebookModels;

public class FacebookData
{
    [JsonPropertyName("id")]
    public IdBase? Id { get; set; }
    
    [JsonPropertyName("branding")]
    public FacebookBranding? Branding { get; set; }
    
    [JsonPropertyName("statistics")]
    public FacebookStatistics? Statistics { get; set; }
    
    [JsonPropertyName("misc")]
    public MiscBase? Base { get; set; }
    
    [JsonPropertyName("ranks")]
    public FacebookRanks? Ranks { get; set; }
    
    [JsonPropertyName("daily")]
    public IReadOnlyList<FacebookDailyStats>? Daily { get; set; }
}