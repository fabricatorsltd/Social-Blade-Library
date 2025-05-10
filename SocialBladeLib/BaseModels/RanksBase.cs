using System.Text.Json.Serialization;

namespace SocialBladeLib.Models;

public abstract class RanksBase
{
    [JsonPropertyName("sbrank")]
    public int SBRank { get; set; }
}