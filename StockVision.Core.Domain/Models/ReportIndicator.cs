namespace StockVision.Core.Domain.Models;

public class ReportIndicator
{
    public CompanyInfo CompanyInfo { get; set; } = new();

    public List<Indicator> IndicatorsData { get; set; } = [];
}