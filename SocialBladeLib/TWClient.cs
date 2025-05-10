using SocialBladeLib.Responses.Instagram;

namespace SocialBladeLib;

public class TWClient
{
    private readonly SBClient _client;

    public TWClient(SBClient client)
    {
        _client = client;
    }

    public TWClient(string clientId, string token)
    {
        _client = new SBClient(clientId, token);
    }
    
    /// <summary>
    /// This endpoint takes as input a username and returns a great amount of information about the channel.
    /// </summary>
    /// <param name="handle">the account handle</param>
    /// <param name="history">how long go back with data
    /// default - 1 credit, up to 30 days worth of data
    /// extended - 2 credits, up to 1 year worth of data (if not available -> auto downgrade)
    /// archive - 3 credits, up to 3 years worth of data (if not available -> auto downgrade)
    /// vault - 5 credits, up to 10 years worth of data (if not available -> auto downgrade)
    /// </param>
    /// <param name="allowStale">allow stale data</param>
    /// <returns>A <see cref="TWCreatorResponse"/> with status and content</returns>
    /// <exception cref="ArgumentException"></exception>
    public async Task<TWCreatorResponse> GetAccountStatisticsAsync(
        string handle,
        string history = "default",
        bool allowStale = false)
    {
        if (string.IsNullOrWhiteSpace(handle))
            throw new ArgumentException("Handle cannot be null or empty.", nameof(handle));
        
        return await _client.GetAsync<TWCreatorResponse>($"twitch/statistics?query={handle}&history={history}&allow-stale={allowStale}");
    }
    
    /// <summary>
    /// This endpoint returns lists of the Top Channels on Twitch
    /// </summary>
    /// <param name="query">Possible lists:
    /// followers
    /// sbrank
    /// </param>
    /// <param name="page">The first page (0) is free, each page after cost 20 credits</param>
    /// <returns>A <see cref="IGTopListResponse"/> with status and content</returns>
    /// <exception cref="ArgumentException"></exception>
    public async Task<TWTopListResponse> GetTopList(
        string query = "followers",
        ushort page = 0)
    {
        if (string.IsNullOrWhiteSpace(query))
            throw new ArgumentException("Query cannot be null or empty.", nameof(query));
        
        return await _client.GetAsync<TWTopListResponse>($"twitch/top?query={query}&page={page}");
    }
}