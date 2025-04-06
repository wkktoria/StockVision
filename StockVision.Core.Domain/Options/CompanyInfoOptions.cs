namespace StockVision.Core.Domain.Options;

public class CompanyInfoOptions
{
    public string Name { get; set; } = string.Empty;

    public string Sector { get; set; } = string.Empty;

    public string Symbol { get; set; } = string.Empty;

    public string Exchange { get; set; } = string.Empty;

    public string StockPrice { get; set; } = string.Empty;
}