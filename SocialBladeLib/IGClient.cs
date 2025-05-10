using SocialBladeLib.Responses.Instagram;

namespace SocialBladeLib;

public class IGClient
{
    private readonly SBClient _client;

    public IGClient(SBClient client)
    {
        _client = client;
    }

    public IGClient(string clientId, string token)
    {
        _client = new SBClient(clientId, token);
    }
    
    /// <summary>
    /// This endpoint takes as input a username and returns a great amount of information about the creator or business profile.
    /// </summary>
    /// <param name="handle">the account handle</param>
    /// <param name="history">how long go back with data
    /// default - 1 credit, up to 30 days worth of data
    /// extended - 2 credits, up to 1 year worth of data (if not available -> auto downgrade)
    /// archive - 3 credits, up to 3 years worth of data (if not available -> auto downgrade)
    /// vault - 5 credits, up to 10 years worth of data (if not available -> auto downgrade)
    /// </param>
    /// <param name="allowStale">allow stale data</param>
    /// <returns>A <see cref="IGCreatorResponse"/> with status and content</returns>
    /// <exception cref="ArgumentException"></exception>
    public async Task<IGCreatorResponse> GetAccountStatisticsAsync(
        string handle,
        string history = "default",
        bool allowStale = false)
    {
        if (string.IsNullOrWhiteSpace(handle))
            throw new ArgumentException("Handle cannot be null or empty.", nameof(handle));
        
        return await _client.GetAsync<IGCreatorResponse>($"instagram/statistics?query={handle}&history={history}&allow-stale={allowStale}");
    }
    
    /// <summary>
    /// This endpoint returns lists of the Top Creator and Business Profiles on Instagram
    /// </summary>
    /// <param name="query">Possible lists:
    /// followers
    /// following
    /// media
    /// engagement-rate
    /// sbrank
    /// </param>
    /// <param name="page">The first page (0) is free, each page after cost 20 credits</param>
    /// <returns>A <see cref="IGTopListResponse"/> with status and content</returns>
    /// <exception cref="ArgumentException"></exception>
    public async Task<IGTopListResponse> GetTopList(
        string query = "followers",
        ushort page = 0)
    {
        if (string.IsNullOrWhiteSpace(query))
            throw new ArgumentException("Query cannot be null or empty.", nameof(query));
        
        return await _client.GetAsync<IGTopListResponse>($"instagram/top?query={query}&page={page}");
    }
}