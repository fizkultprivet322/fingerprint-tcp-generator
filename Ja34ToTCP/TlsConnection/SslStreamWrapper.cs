using System.Net.Security;

namespace Ja34ToTCP.TlsConnection;

public class SslStreamWrapper : ISslStreamWrapper
{
    private readonly SslStream _sslStream;

    public SslStreamWrapper(SslStream sslStream)
    {
        _sslStream = sslStream;
    }

    public bool IsAuthenticated => _sslStream.IsAuthenticated;

    public string CipherAlgorithm => _sslStream.CipherAlgorithm.ToString();

    public string Protocol => _sslStream.SslProtocol.ToString();

    public void AuthenticateAsClient(string targetHost)
    {
        _sslStream.AuthenticateAsClient(targetHost);
    }
}