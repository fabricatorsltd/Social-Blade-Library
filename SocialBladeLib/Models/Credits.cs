using System.Text.Json.Serialization;

namespace SocialBladeLib.Models;

public class Credits
{
    [JsonPropertyName("available")]
    public int Available { get; set; }
}