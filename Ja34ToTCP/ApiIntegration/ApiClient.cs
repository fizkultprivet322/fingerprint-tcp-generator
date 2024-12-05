using System.Text.Json;

namespace Ja34ToTCP.ApiIntegration;

public class ApiClient
{
    private readonly HttpClient _httpClient;
    private readonly string _apiKey;

    public ApiClient(HttpClient httpClient, string apiKey)
    {
        _httpClient = httpClient;
        _apiKey = apiKey;
    }

    public async Task<string> GetFingerprintDetailsAsync(string ja3Hash)
    {
        try
        {
            var requestUri = $"https://api.example.com/fingerprint/{ja3Hash}";
            var request = new HttpRequestMessage(HttpMethod.Get, requestUri);
            request.Headers.Add("Authorization", $"Bearer {_apiKey}");

            var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Serialize(
                JsonSerializer.Deserialize<dynamic>(jsonResponse),
                new JsonSerializerOptions { WriteIndented = true }
            );
        }
        catch (Exception ex)
        {
            return $"Error fetching JA3 details: {ex.Message}";
        }
    }
}