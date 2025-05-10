using System.Text.Json.Serialization;
using SocialBladeLib.Models;

namespace SocialBladeLib.YouTubeModels;

public class YouTubeId : IdBase
{
    [JsonPropertyName("cusername")]
    public string? CUsername { get; set; }
    
    [JsonPropertyName("handle")]
    public string? Handle { get; set; }
}