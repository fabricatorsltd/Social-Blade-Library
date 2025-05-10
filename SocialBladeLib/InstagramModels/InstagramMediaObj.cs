using System.Text.Json.Serialization;

namespace SocialBladeLib.InstagramModels;

public class InstagramMediaObj
{
    [JsonPropertyName("recent")]
    public IReadOnlyList<InstagramMedia>? Recent { get; set; }
}