using System.Security.Authentication;
using Ja34ToTCP.ApiIntegration;
using Ja34ToTCP.Exceptions;
using Ja34ToTCP.FingerprintGenerator;
using Ja34ToTCP.TlsConnection;

namespace Ja34ToTCP;

public class Program
{
    static async Task Main()
    {
        string host = "example.com"; // Target host
        int port = 443;             // Target port
        var tlsConnection = new Connection();

        string tlsParameters = tlsConnection.GetTlsParameters(host, port, SslProtocols.Tls13);
        if (tlsParameters.Contains("Ошибка"))
        {
            Console.WriteLine($"TLS 1.3 failed: {tlsParameters}. Trying TLS 1.2...");
            tlsParameters = tlsConnection.GetTlsParameters(host, port, SslProtocols.Tls12);
        }

        var parameters = tlsParameters.Split(',');
        if (parameters.Length < 2)
        {
            Console.WriteLine("Not enough data to generate fingerprints.");
            return;
        }

        string tlsVersion = parameters[0];
        string cipherSuites = parameters[1];

        var ja3Generator = new Ja3Generator();
        string ja3Fingerprint = ja3Generator.GenerateJa3Fingerprint(tlsVersion, cipherSuites);
        Console.WriteLine($"Generated JA3 Fingerprint: {ja3Fingerprint}");
            
        var httpClient = new HttpClient();
        var apiKey = "YOUR_API_KEY"; // Replace with your actual API key
        var apiClient = new ApiClient(httpClient, apiKey);

        Console.WriteLine("Fetching JA3 details from API...");
        string ja3Details = await apiClient.GetFingerprintDetailsAsync(ja3Fingerprint);
        Console.WriteLine($"JA3 Details: {ja3Details}");
        
        string extensions = "extension1,extension2";
        string quicParameters = "quicParam1,quicParam2";
        var ja4Generator = new Ja4Generator();
        string ja4Fingerprint = ja4Generator.GenerateJa4Fingerprint(tlsVersion, cipherSuites, extensions, quicParameters);
        Console.WriteLine($"Generated JA4 Fingerprint: {ja4Fingerprint}");
    } 
}
