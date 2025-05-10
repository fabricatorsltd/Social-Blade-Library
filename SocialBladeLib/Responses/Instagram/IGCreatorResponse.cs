using System.Text.Json.Serialization;
using SocialBladeLib.InstagramModels;
using SocialBladeLib.Models;

namespace SocialBladeLib.Responses.Instagram;

public class IGCreatorResponse : ResponseBase
{
    [JsonPropertyName("data")]
    public InstagramData? Data { get; set; }
}