using System.Text.Json.Serialization;
using SocialBladeLib.Models;

namespace SocialBladeLib.FacebookModels;

public class FacebookGrowth
{
    [JsonPropertyName("likes")]
    public GrowthTrack? Likes { get; set; }
    
    [JsonPropertyName("talking_about")]
    public GrowthTrack? TalkingAbout { get; set; }
}