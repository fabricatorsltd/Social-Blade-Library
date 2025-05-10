namespace SocialBladeLib.UnitTests;

public class FacebookTests
{
    private readonly string _clientId = "";
    private readonly string _token = "";
    
    [Fact]
    public async Task SocialBladeAccount()
    {
        var client = new FBClient(_clientId, _token);
        var response = await client.GetAccountStatisticsAsync("socialblade");
        
        Assert.NotNull(response);
        Assert.Equal(200, response.Status.StatusCode);
        Assert.NotNull(response.Data);
        Assert.NotNull(response.Data.Id);
        Assert.Equal("145754375148", response.Data.Id.Id);
    }
    
    [Fact]
    public async Task TopList()
    {
        var client = new FBClient(_clientId, _token);
        var response = await client.GetTopList();
        
        Assert.NotNull(response);
        Assert.Equal(200, response.Status.StatusCode);
        Assert.NotNull(response.Data);
        Assert.NotEmpty(response.Data);
    }
}