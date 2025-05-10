using System.Text.Json.Serialization;
using SocialBladeLib.Models;
using SocialBladeLib.YouTubeModels;

namespace SocialBladeLib.Responses.YouTube;

public class YTTopListResponse : ResponseBase
{
    [JsonPropertyName("data")]
    public IReadOnlyList<YouTubeData>? Data { get; set; }
}