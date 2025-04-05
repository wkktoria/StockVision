namespace StockVision.Core.Domain.Interfaces.Services;

public interface IFinancialReportService
{
    Task PrepareFinancialReportAsync(string symbol);
}