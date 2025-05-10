using System.Text.Json.Serialization;

namespace SocialBladeLib.Models;

public class Info
{
    [JsonPropertyName("access")]
    public Access? Access { get; set; }
    
    [JsonPropertyName("credits")]
    public Credits? Credits { get; set; }
}