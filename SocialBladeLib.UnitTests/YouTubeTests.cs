namespace SocialBladeLib.UnitTests;

public class YouTubeTests
{
    private readonly string _clientId = "";
    private readonly string _token = "";
    
    [Fact]
    public async Task SocialBladeAccount()
    {
        var client = new YTClient(_clientId, _token);
        var response = await client.GetChannelStatisticsAsync("socialblade");
        
        Assert.NotNull(response);
        Assert.Equal(200, response.Status.StatusCode);
        Assert.NotNull(response.Data);
        Assert.NotNull(response.Data.Id);
        Assert.Equal("UCl6vWwMCjufI8OPtOInHf0g", response.Data.Id.Id);
    }
    
    [Fact]
    public async Task TopList()
    {
        var client = new YTClient(_clientId, _token);
        var response = await client.GetTopList();
        
        Assert.NotNull(response);
        Assert.Equal(200, response.Status.StatusCode);
        Assert.NotEmpty(response.Data);
    }
}