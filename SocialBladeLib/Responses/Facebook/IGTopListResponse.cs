using System.Text.Json.Serialization;
using SocialBladeLib.FacebookModels;
using SocialBladeLib.Models;

namespace SocialBladeLib.Responses.Facebook;

public class FBTopListResponse : ResponseBase
{
    [JsonPropertyName("data")]
    public IReadOnlyList<FacebookData>? Data { get; set; }
}