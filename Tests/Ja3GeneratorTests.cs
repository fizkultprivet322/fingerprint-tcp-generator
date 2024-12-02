using Ja34ToTCP.FingerprintGenerator;
using Xunit;
using Assert = Xunit.Assert;

namespace Ja34ToTCPTest;

public class Ja3GeneratorTests
{
    [Fact]
    public void GenerateJa3Fingerprint_ShouldReturnCorrectFingerprint()
    {
        // Arrange
        var generator = new Ja3Generator();
        string tlsVersion = "Tls12";
        string cipherSuites = "Aes128";

        // Act
        var fingerprint = generator.GenerateJa3Fingerprint(tlsVersion, cipherSuites);

        // Assert
        Assert.NotNull(fingerprint);
        Assert.NotEmpty(fingerprint);
    }
}