using System.Text.Json.Serialization;
using SocialBladeLib.Models;
using SocialBladeLib.TikTokModels;

namespace SocialBladeLib.Responses.TikTok;

public class TTCreatorResponse : ResponseBase
{
    [JsonPropertyName("data")]
    public TiktokData? Data { get; set; }
}