using System.Text.Json.Serialization;
using SocialBladeLib.Models;
using SocialBladeLib.TwitchModels;

namespace SocialBladeLib.Responses.Instagram;

public class TWTopListResponse : ResponseBase
{
    [JsonPropertyName("data")]
    public IReadOnlyList<TwitchData>? Data { get; set; }
}