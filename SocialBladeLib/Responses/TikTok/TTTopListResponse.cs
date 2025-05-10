using System.Text.Json.Serialization;
using SocialBladeLib.Models;
using SocialBladeLib.TikTokModels;

namespace SocialBladeLib.Responses.TikTok;

public class TTTopListResponse : ResponseBase
{
    [JsonPropertyName("data")]
    public IReadOnlyList<TiktokData>? Data { get; set; }
}