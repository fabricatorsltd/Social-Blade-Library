using System.Text.Json.Serialization;
using SocialBladeLib.Models;
using SocialBladeLib.YouTubeModels;

namespace SocialBladeLib.Responses.YouTube;

public class YTChannelResponse : ResponseBase
{
    [JsonPropertyName("data")]
    public YouTubeData? Data { get; set; }
}