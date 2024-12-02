using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using Ja34ToTCP.Exceptions;

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

            throw new TlsConnectionException($"Could not handle connection {sslProtocol} for {host}");
        }
        catch (Exception ex)
        {
            throw new TlsConnectionException($"Error trying to connect with version {sslProtocol}: {ex.Message}", ex);
        }
    }
}