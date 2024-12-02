using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
namespace Ja34ToTCP.TlsConnection;

public class Connection
{
    private readonly Func<SslStream, ISslStreamWrapper> _sslStreamWrapperFactory;

    public Connection(Func<SslStream, ISslStreamWrapper>? sslStreamWrapperFactory = null)
    {
        _sslStreamWrapperFactory = sslStreamWrapperFactory ?? (stream => new SslStreamWrapper(stream));
    }

    public string GetTlsParameters(string host, int port, SslProtocols sslProtocol)
    {
        try
        {
            using var tcpClient = new TcpClient(host, port);
            var sslStream = new SslStream(tcpClient.GetStream());
            var wrapper = _sslStreamWrapperFactory(sslStream);

            wrapper.AuthenticateAsClient(host);

            if (wrapper.IsAuthenticated)
            {
                return $"{wrapper.Protocol},{wrapper.CipherAlgorithm}";
            }

            return $"Не удалось установить соединение с {sslProtocol} для {host}";
        }
        catch (Exception ex)
        {
            return $"Ошибка при подключении с версией {sslProtocol}: {ex.Message}";
        }
    }
}