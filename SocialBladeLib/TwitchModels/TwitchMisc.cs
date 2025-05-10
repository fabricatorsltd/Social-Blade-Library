using System.Text.Json.Serialization;
using SocialBladeLib.Models;

namespace SocialBladeLib.TwitchModels;

public class TwitchMisc : MiscBase
{
    [JsonPropertyName("recent")]
    public TwitchRecent? Recent { get; set; }
    
    [JsonPropertyName("mature_warning")]
    public bool IsMature { get; set; }
    
}