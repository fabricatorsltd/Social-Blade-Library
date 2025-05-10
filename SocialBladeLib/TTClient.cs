using SocialBladeLib.Responses.TikTok;

namespace SocialBladeLib;

public class TTClient
{
    private readonly SBClient _client;

    public TTClient(SBClient client)
    {
        _client = client;
    }

    public TTClient(string clientId, string token)
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
    /// <returns>A <see cref="TTCreatorResponse"/> with status and content</returns>
    /// <exception cref="ArgumentException"></exception>
    public async Task<TTCreatorResponse> GetAccountStatisticsAsync(
        string handle,
        string history = "default",
        bool allowStale = false)
    {
        if (string.IsNullOrWhiteSpace(handle))
            throw new ArgumentException("Handle cannot be null or empty.", nameof(handle));
        
        return await _client.GetAsync<TTCreatorResponse>($"tiktok/statistics?query={handle}&history={history}&allow-stale={allowStale}");
    }
    
    /// <summary>
    /// This endpoint returns lists of the Top Channels on TikTok
    /// </summary>
    /// <param name="query">Possible lists:
    /// followers
    /// following
    /// likes
    /// videos
    /// sbrank
    /// </param>
    /// <param name="page">The first page (0) is free, each page after cost 20 credits</param>
    /// <returns>A <see cref="TTTopListResponse"/> with status and content</returns>
    /// <exception cref="ArgumentException"></exception>
    public async Task<TTTopListResponse> GetTopList(
        string query = "followers",
        ushort page = 0)
    {
        if (string.IsNullOrWhiteSpace(query))
            throw new ArgumentException("Query cannot be null or empty.", nameof(query));
        
        return await _client.GetAsync<TTTopListResponse>($"tiktok/top?query={query}&page={page}");
    }
}