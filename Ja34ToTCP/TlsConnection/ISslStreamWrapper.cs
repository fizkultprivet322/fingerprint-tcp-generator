namespace Ja34ToTCP.TlsConnection;

public interface ISslStreamWrapper
{
    bool IsAuthenticated { get; }
    string CipherAlgorithm { get; }
    string Protocol { get; }
    void AuthenticateAsClient(string targetHost);
}