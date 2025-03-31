namespace StockVision.Infrastructure.Attributes;

public class ApiEndpointAttribute : Attribute
{
    public required string Endpoint { get; set; }
}