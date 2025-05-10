using SocialBladeLib.Responses.YouTube;

namespace SocialBladeLib;

public class YTClient
{
    private readonly SBClient _client;

    public YTClient(SBClient client)
    {
        _client = client;
    }

    public YTClient(string clientId, string token)
    {
        _client = new SBClient(clientId, token);
    }
    
    /// <summary>
    /// This endpoint takes as input a channelid, username, or handle (supply the @ in your request) and returns a great amount of information about the channel.
    /// </summary>
    /// <param name="channelId">the channel to retrieve
    /// channelid - preferred method to insure you get the right data
    /// username
    /// cusername
    /// @handle - include the @ symbol</param>
    /// <param name="history">how long go back with data
    /// default - 1 credit, up to 30 days worth of data
    /// extended - 2 credits, up to 1 year worth of data (if not available -> auto downgrade)
    /// archive - 3 credits, up to 3 years worth of data (if not available -> auto downgrade)
    /// </param>
    /// <param name="allowStale">allow stale data</param>
    /// <returns>A <see cref="YTChannelResponse"/> with status and content</returns>
    /// <exception cref="ArgumentException"></exception>
    public async Task<YTChannelResponse> GetChannelStatisticsAsync(
        string channelId,
        string history = "default",
        bool allowStale = false)
    {
        if (string.IsNullOrWhiteSpace(channelId))
            throw new ArgumentException("Channel ID cannot be null or empty.", nameof(channelId));
        
        return await _client.GetAsync<YTChannelResponse>($"youtube/statistics?query={channelId}&history={history}&allow-stale={allowStale}");
    }
    
    /// <summary>
    /// This endpoint returns lists of the Top Channels on YouTube
    /// </summary>
    /// <param name="query">Possible lists:
    /// subscribers
    /// sbrank
    /// views
    /// </param>
    /// <param name="page">The first page (0) is free, each page after cost 20 credits</param>
    /// <returns>A <see cref="YTTopListResponse"/> with status and content</returns>
    /// <exception cref="ArgumentException"></exception>
    public async Task<YTTopListResponse> GetTopList(
        string query = "subscribers",
        ushort page = 0)
    {
        if (string.IsNullOrWhiteSpace(query))
            throw new ArgumentException("Query cannot be null or empty.", nameof(query));
        
        return await _client.GetAsync<YTTopListResponse>($"youtube/top?query={query}&page={page}");
    }
}