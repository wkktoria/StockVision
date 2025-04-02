using StockVision.Core.Domain.Responses;

namespace StockVision.Core.Domain.Interfaces.Services;

public interface IIndicatorReportPeriodicService<T> where T : ApiReportBase
{
    public Task FillFormulaByPeriodicReportAsync(string symbol);
}