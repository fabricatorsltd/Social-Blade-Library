using System.Text.Json.Serialization;
using SocialBladeLib.Models;

namespace SocialBladeLib.TwitchModels;

public class TwitchGrowth
{
    [JsonPropertyName("followers")]
    public GrowthTrack? Followers { get; set; }
}