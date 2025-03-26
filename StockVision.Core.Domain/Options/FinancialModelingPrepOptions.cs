namespace StockVision.Core.Domain.Options;

public class FinancialModelingPrepOptions
{
    public string ApiUrl { get; set; } = string.Empty;
    
    public string ApiKey { get; set; } = string.Empty;
    
    public int Limit { get; set; }
}