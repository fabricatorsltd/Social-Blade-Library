using SocialBladeLib.Responses.Facebook;

namespace SocialBladeLib;

public class FBClient
{
    private readonly SBClient _client;

    public FBClient(SBClient client)
    {
        _client = client;
    }

    public FBClient(string clientId, string token)
    {
        _client = new SBClient(clientId, token);
    }
    
    /// <summary>
    /// This endpoint takes as input a page username and returns a great amount of information about the page.
    /// </summary>
    /// <param name="handle">the account handle</param>
    /// <param name="history">how long go back with data
    /// default - 1 credit, up to 30 days worth of data
    /// extended - 2 credits, up to 1 year worth of data (if not available -> auto downgrade)
    /// archive - 3 credits, up to 3 years worth of data (if not available -> auto downgrade)
    /// vault - 5 credits, up to 10 years worth of data (if not available -> auto downgrade)
    /// </param>
    /// <param name="allowStale">allow stale data</param>
    /// <returns>A <see cref="FBCreatorResponse"/> with status and content</returns>
    /// <exception cref="ArgumentException"></exception>
    public async Task<FBCreatorResponse> GetAccountStatisticsAsync(
        string handle,
        string history = "default",
        bool allowStale = false)
    {
        if (string.IsNullOrWhiteSpace(handle))
            throw new ArgumentException("Handle cannot be null or empty.", nameof(handle));
        
        return await _client.GetAsync<FBCreatorResponse>($"facebook/statistics?query={handle}&history={history}&allow-stale={allowStale}");
    }
    
    /// <summary>
    /// This endpoint returns lists of the Top Pages on Facebook
    /// </summary>
    /// <param name="query">Possible lists:
    /// likes
    /// talking-about
    /// sbrank
    /// </param>
    /// <param name="page">The first page (0) is free, each page after cost 20 credits</param>
    /// <returns>A <see cref="FBTopListResponse"/> with status and content</returns>
    /// <exception cref="ArgumentException"></exception>
    public async Task<FBTopListResponse> GetTopList(
        string query = "likes",
        ushort page = 0)
    {
        if (string.IsNullOrWhiteSpace(query))
            throw new ArgumentException("Query cannot be null or empty.", nameof(query));
        
        return await _client.GetAsync<FBTopListResponse>($"facebook/top?query={query}&page={page}");
    }
}