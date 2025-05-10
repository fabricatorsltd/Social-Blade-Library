using System.Text.Json.Serialization;

namespace SocialBladeLib.FacebookModels;

public class FacebookRanks : FacebookStatisticsBase
{
    [JsonPropertyName("sbrank")]
    public int SBRank { get; set; }
}