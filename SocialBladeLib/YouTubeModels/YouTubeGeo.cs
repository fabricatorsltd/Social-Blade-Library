using System.Text.Json.Serialization;

namespace SocialBladeLib.YouTubeModels;

public class YouTubeGeo
{
    [JsonPropertyName("country_code")]
    public string? CountryCode { get; set; }
    
    [JsonPropertyName("country")]
    public string? Country { get; set; }
}