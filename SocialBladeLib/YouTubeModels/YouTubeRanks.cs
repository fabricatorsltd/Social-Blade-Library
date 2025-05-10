using System.Text.Json.Serialization;
using SocialBladeLib.Models;

namespace SocialBladeLib.YouTubeModels;

public class YouTubeRanks : RanksBase
{
    [JsonPropertyName("subscribers")]
    public long? Subscribers { get; set; }
    
    [JsonPropertyName("views")]
    public long? Views { get; set; }
    
    [JsonPropertyName("country")]
    public int? Country { get; set; }
    
    [JsonPropertyName("channel_type")]
    public int? ChannelType { get; set; }
}