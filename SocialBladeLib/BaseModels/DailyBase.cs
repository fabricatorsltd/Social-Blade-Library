using System.Text.Json.Serialization;

namespace SocialBladeLib.Models;

public abstract class DailyBase
{
    [JsonPropertyName("date")]
    public string? Date { get; set; }
}