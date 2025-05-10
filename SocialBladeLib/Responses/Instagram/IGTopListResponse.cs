using System.Text.Json.Serialization;
using SocialBladeLib.InstagramModels;
using SocialBladeLib.Models;

namespace SocialBladeLib.Responses.Instagram;

public class IGTopListResponse : ResponseBase
{
    [JsonPropertyName("data")]
    public IReadOnlyList<InstagramData>? Data { get; set; }
}