using System.Text.Json.Serialization;

namespace SocialBladeLib.FacebookModels;

public class FacebookStatisticsBase
{
    [JsonPropertyName("likes")]
    public long? Likes { get; set; }
    
    [JsonPropertyName("talking_about")]
    public long? TalkingAbout { get; set; }
}