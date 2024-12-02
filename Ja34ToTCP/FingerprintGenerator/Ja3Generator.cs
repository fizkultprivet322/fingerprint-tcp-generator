using Ja34ToTCP.Utils;

namespace Ja34ToTCP.FingerprintGenerator;

public class Ja3Generator
{
    public string GenerateJa3Fingerprint(string tlsVersion, string cipherSuites)
    {
        string fingerprintString = $"{tlsVersion},{cipherSuites}";
                
        return Md5Hashing.ComputeMd5(fingerprintString);
    }
}