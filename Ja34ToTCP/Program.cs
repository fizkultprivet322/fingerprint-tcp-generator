using System.Security.Authentication;
using Ja34ToTCP.FingerprintGenerator;
using Ja34ToTCP.TlsConnection;

namespace Ja34ToTCP;

public class Program
{
    static void Main(string[] args)
    {
        string host = "example.com"; // Задайте целевой хост
        int port = 443;             // Задайте порт

        var tlsConnection = new Connection();

        string tlsParameters = tlsConnection.GetTlsParameters(host, port, SslProtocols.Tls13);
        if (tlsParameters.Contains("Ошибка"))
        {
            Console.WriteLine($"Ошибка с TLS 1.3: {tlsParameters}. Попытка с TLS 1.2...");
            tlsParameters = tlsConnection.GetTlsParameters(host, port, SslProtocols.Tls12);
        }

        var parameters = tlsParameters.Split(',');

        if (parameters.Length < 2)
        {
            Console.WriteLine("Недостаточно данных для генерации отпечатков.");
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
}