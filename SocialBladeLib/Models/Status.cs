using System.Text.Json.Serialization;

namespace SocialBladeLib.Models;

public class Status
{
    [JsonPropertyName("success")]
    public bool? Success { get; set; }
    
    [JsonPropertyName("status")]
    public int StatusCode { get; set; }
    
    [JsonPropertyName("error")]
    public string? Error { get; set; }
}