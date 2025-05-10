using System.Text.Json.Serialization;

namespace SocialBladeLib.TikTokModels;

public class TikTokRanks : TikTokStatsBase
{
    [JsonPropertyName("sbrank")]
    public int SBRank { get; set; }
}