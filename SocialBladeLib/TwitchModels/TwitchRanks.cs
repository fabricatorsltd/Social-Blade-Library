using System.Text.Json.Serialization;
using SocialBladeLib.Models;

namespace SocialBladeLib.TwitchModels;

public class TwitchRanks : TwitchStatisticsBase
{
    [JsonPropertyName("sbrank")]
    public int SBRank { get; set; }
}