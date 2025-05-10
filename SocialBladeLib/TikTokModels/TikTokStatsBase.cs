using System.Text.Json.Serialization;

namespace SocialBladeLib.TikTokModels;

public class TikTokStatsBase
{
    [JsonPropertyName("followers")]
    public long? Followers { get; set; }
    
    [JsonPropertyName("following")]
    public long? Following { get; set; }
    
    [JsonPropertyName("likes")]
    public long? Likes { get; set; }
    
    [JsonPropertyName("uploads")]
    public int? Uploads { get; set; }
}