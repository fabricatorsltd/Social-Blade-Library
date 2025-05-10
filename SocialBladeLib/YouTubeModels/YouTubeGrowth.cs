using System.Text.Json.Serialization;
using SocialBladeLib.Models;

namespace SocialBladeLib.YouTubeModels;

public class YouTubeGrowth
{
    [JsonPropertyName("subs")]
    public GrowthTrack? Subs { get; set; }
    
    [JsonPropertyName("vidviews")]
    public GrowthTrack? VidViews { get; set; }
}