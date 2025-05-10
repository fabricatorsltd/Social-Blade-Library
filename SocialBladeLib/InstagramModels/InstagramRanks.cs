using System.Text.Json.Serialization;

namespace SocialBladeLib.InstagramModels;

public class InstagramRanks : InstagramStatisticsFull
{
    [JsonPropertyName("sbrank")]
    public int SBRank { get; set; }
}