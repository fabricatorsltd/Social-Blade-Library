using System.Text.Json.Serialization;

namespace SocialBladeLib.Models;

public class Access
{
    [JsonPropertyName("seconds_to_expire")]
    public int SecondsToExpire { get; set; }
}