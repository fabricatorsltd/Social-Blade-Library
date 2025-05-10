using System.Text.Json.Serialization;

namespace SocialBladeLib.YouTubeModels;

public class YouTubeMedia
{
    [JsonPropertyName("recent")]
    public IReadOnlyList<YouTubeMedia>? Recent { get; set; }
}