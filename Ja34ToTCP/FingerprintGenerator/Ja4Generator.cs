using Ja34ToTCP.Utils;

namespace Ja34ToTCP.FingerprintGenerator;

public class Ja4Generator
{
    public string GenerateJa4Fingerprint(string tlsVersion, string cipherSuites, string extensions, string quicParameters)
    {
        string fingerprintString = $"{tlsVersion},{cipherSuites},{extensions},{quicParameters}";
            
        return Md5Hashing.ComputeMd5(fingerprintString);
    }
}