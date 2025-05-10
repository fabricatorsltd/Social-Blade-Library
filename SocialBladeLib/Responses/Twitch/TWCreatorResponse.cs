using System.Text.Json.Serialization;
using SocialBladeLib.Models;
using SocialBladeLib.TwitchModels;

namespace SocialBladeLib.Responses.Instagram;

public class TWCreatorResponse : ResponseBase
{
    [JsonPropertyName("data")]
    public TwitchData? Data { get; set; }
}