using System.Text.Json.Serialization;
using SocialBladeLib.Models;

namespace SocialBladeLib.InstagramModels;

public class InstagramGrowth
{
    [JsonPropertyName("followers")]
    public GrowthTrack? Followers { get; set; }
    
    [JsonPropertyName("media")]
    public GrowthTrack? Media { get; set; }
}