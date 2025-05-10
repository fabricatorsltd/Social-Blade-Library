using System.Text.Json.Serialization;

namespace SocialBladeLib.TwitchModels;

public class TwitchGeo
{
    [JsonPropertyName("broadcaster_language")]
    public string? BroadcasterLanguage { get; set; }
}