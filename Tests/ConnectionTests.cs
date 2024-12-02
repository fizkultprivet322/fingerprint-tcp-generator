using Ja34ToTCP.TlsConnection;
using Moq;
using Xunit;
using Assert = Xunit.Assert;

namespace Ja34ToTCPTest;

public class ConnectionTests
{
    [Fact]
    public void GetTlsParameters_ShouldReturnTlsInfo()
    {
        // Arrange
        var mockSslStream = new Mock<ISslStreamWrapper>();
        mockSslStream.SetupGet(x => x.IsAuthenticated).Returns(true);
        mockSslStream.SetupGet(x => x.CipherAlgorithm).Returns("Aes128");
        mockSslStream.SetupGet(x => x.Protocol).Returns("Tls12");

        var connection = new Connection(sslStream => mockSslStream.Object);

        // Act
        string result = connection.GetTlsParameters("example.com", 443, System.Security.Authentication.SslProtocols.Tls12);

        // Assert
        Assert.Equal("Tls12,Aes128", result);
    }

    [Fact]
    public void GetTlsParameters_ShouldHandleConnectionFailure()
    {
        // Arrange
        var mockSslStream = new Mock<ISslStreamWrapper>();
        mockSslStream.Setup(x => x.AuthenticateAsClient(It.IsAny<string>()))
            .Throws(new InvalidOperationException("Connection failed"));

        var connection = new Connection(sslStream => mockSslStream.Object);

        // Act
        string result = connection.GetTlsParameters("example.com", 443, System.Security.Authentication.SslProtocols.Tls12);

        // Assert
        Assert.Contains("Ошибка при подключении", result);
    }
}