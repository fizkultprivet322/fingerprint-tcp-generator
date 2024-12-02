namespace Ja34ToTCP.Exceptions;

public class TlsConnectionException : Exception
{
    public TlsConnectionException(string message, Exception? innerException = null)
        : base(message, innerException) { }
}