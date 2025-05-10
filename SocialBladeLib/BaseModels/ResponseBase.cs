using System.Text.Json.Serialization;

namespace SocialBladeLib.Models;

public abstract class ResponseBase
{
    [JsonPropertyName("status")]
    public Status? Status { get; set; }
    
    [JsonPropertyName("info")]
    public Info? Info { get; set; }
}