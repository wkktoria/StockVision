namespace StockVision.Core.Domain.Exceptions;

public class ExternalServiceException : Exception
{
    public ExternalServiceException()
    {
    }

    public ExternalServiceException(string? message) : base(message)
    {
    }

    public ExternalServiceException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    public override string ToString()
    {
        return "Error in external service. Please contact the administrator.";
    }
}