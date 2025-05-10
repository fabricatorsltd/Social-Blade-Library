using System.Net.Http.Headers;
using System.Text.Json;

namespace SocialBladeLib;

public class SBClient : IDisposable
{
    private readonly HttpClient _httpClient;
    private readonly string _baseUrl = "https://matrix.sbapis.com/b/";
    private readonly JsonSerializerOptions _jsonOptions;
    
    public SBClient(string clientId, string token)
    {
        _httpClient = new HttpClient
        {
            BaseAddress = new Uri(_baseUrl)
        };
        _httpClient.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
        _httpClient.DefaultRequestHeaders.Add("clientid", clientId);
        _httpClient.DefaultRequestHeaders.Add("token", token);

        _jsonOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
            WriteIndented = false
        };
    }
    
    /// <summary>
    /// Send GET request to specified endpoint.
    /// </summary>
    /// <param name="endpoint">Endpoint without base address (eg. "youtube/statistics").</param>
    /// <typeparam name="TResponse">Type of response</typeparam>
    /// <returns>Deserialized response.</returns>
    public async Task<TResponse> GetAsync<TResponse>(string endpoint)
    {
        var response = await _httpClient.GetAsync(endpoint);
        response.EnsureSuccessStatusCode();
        var json = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<TResponse>(json, _jsonOptions)!;
    }

    private void Dispose(bool disposing)
    {
        if (disposing)
        {
            _httpClient.Dispose();
        }
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    ~SBClient()
    {
        Dispose(false);
    }
}