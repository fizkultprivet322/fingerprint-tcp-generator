using System.Security.Authentication;
using Ja34ToTCP.Exceptions;
using Ja34ToTCP.FingerprintGenerator;
using Ja34ToTCP.TlsConnection;

namespace Ja34ToTCP;

public class Program
{
    static void Main()
    {
        string host = "example.com"; // Задайте целевой хост
        int port = 443;             // Задайте порт

        var tlsConnection = new Connection();

        try
        {
            string tlsParameters = tlsConnection.GetTlsParameters(host, port, SslProtocols.Tls13);

            var parameters = tlsParameters.Split(',');

            if (parameters.Length < 2)
            {
                Console.WriteLine("Not enough data to connect.");
                return;
            }

            string tlsVersion = parameters[0];
            string cipherSuites = parameters[1];

            var ja3Generator = new Ja3Generator();
            string ja3Fingerprint = ja3Generator.GenerateJa3Fingerprint(tlsVersion, cipherSuites);
            Console.WriteLine($"JA3 Fingerprint: {ja3Fingerprint}");

            string extensions = "extension1,extension2";
            string quicParameters = "quicParam1,quicParam2";

            var ja4Generator = new Ja4Generator();
            string ja4Fingerprint = ja4Generator.GenerateJa4Fingerprint(tlsVersion, cipherSuites, extensions, quicParameters);
            Console.WriteLine($"JA4 Fingerprint: {ja4Fingerprint}");
        }
        catch (TlsConnectionException ex)
        {
            Console.WriteLine($"Connection error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unknown error: {ex.Message}");
        }
    }
}