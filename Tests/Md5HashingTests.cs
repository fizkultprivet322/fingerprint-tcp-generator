using Ja34ToTCP.Utils;
using Xunit;
using Assert = Xunit.Assert;

namespace Ja34ToTCPTest;

public class Md5HashingTests
{
    [Xunit.Theory]
    [InlineData("hello", "5d41402abc4b2a76b9719d911017c592")]
    [InlineData("example", "1a79a4d60de6718e8e5b326e338ae533")]
    [InlineData("123456", "e10adc3949ba59abbe56e057f20f883e")]
    public void ComputeMd5_ShouldReturnCorrectHash(string input, string expectedHash)
    {
        // Act
        var result = Md5Hashing.ComputeMd5(input);

        // Assert
        Assert.Equal(expectedHash, result);
    }
}