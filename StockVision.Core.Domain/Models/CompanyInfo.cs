namespace StockVision.Core.Domain.Models;

public class CompanyInfo
{
    public string Name { get; private set; } = string.Empty;

    public string Sector { get; private set; } = string.Empty;

    public string Symbol { get; private set; } = string.Empty;

    public string Exchange { get; private set; } = string.Empty;

    public string StockPrice { get; private set; } = string.Empty;

    public void UpdateCompanyInfo(string name, string sector, string symbol, string exchange, string stockPrice)
    {
        Name = name;
        Sector = sector;
        Symbol = symbol;
        Exchange = exchange;
        StockPrice = stockPrice;
    }
}