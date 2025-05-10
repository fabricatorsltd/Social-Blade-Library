using System.Text.Json.Serialization;

namespace SocialBladeLib.Models;

public class MiscBase
{
    [JsonPropertyName("grade")]
    public SBGrade? Grade { get; set; }

    [JsonPropertyName("sb_verified")] 
    public bool SbVerified { get; set; } = false;
}