using StockVision.Core.Domain.Models;
using StockVision.Core.Domain.Responses;

namespace StockVision.Core.Domain.Interfaces.Services;

public interface IIndicatorReportPeriodicService<T> where T : ApiReportBase
{
    public Task FillFormulaByPeriodicReportAsync(string symbol, Dictionary<int, ReportIndicator> resultDictionary);
}