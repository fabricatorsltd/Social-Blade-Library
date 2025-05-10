using System.Text.Json.Serialization;

namespace SocialBladeLib.Models;

public class SBGrade
{
    [JsonPropertyName("color")]
    public string? Color { get; set; }
    
    [JsonPropertyName("grade")]
    public string? Grade { get; set; }
}