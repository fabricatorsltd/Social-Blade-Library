using System.Text.Json.Serialization;
using SocialBladeLib.FacebookModels;
using SocialBladeLib.Models;

namespace SocialBladeLib.Responses.Facebook;

public class FBCreatorResponse : ResponseBase
{
    [JsonPropertyName("data")]
    public FacebookData? Data { get; set; }
}