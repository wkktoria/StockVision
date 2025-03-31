using StockVision.Core.Domain.Responses;

namespace StockVision.Core.Domain.Interfaces.Repositories;

public interface IFinancialReportRepository<T> where T: ApiReportBase
{
    Task<List<T>> GetDataAsync(string symbol);
}