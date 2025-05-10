using System.Text.Json.Serialization;
using SocialBladeLib.Models;

namespace SocialBladeLib.YouTubeModels;

public class YouTubeDailyRecord : DailyBase
{
    [JsonPropertyName("subs")]
    public long? Subscribers { get; set; }
    
    [JsonPropertyName("views")]
    public long? Views { get; set; }
}