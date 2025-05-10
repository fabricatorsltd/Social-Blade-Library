using System.Text.Json.Serialization;

namespace SocialBladeLib.Models;

public class IdBase
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    
    [JsonPropertyName("username")]
    public string? Username { get; set; }
    
    [JsonPropertyName("display_name")]
    public string? DisplayName { get; set; }
}