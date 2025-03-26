using StockVision.Core.Domain.Responses;

namespace StockVision.Core.Domain.Interfaces.Repositories;

public interface IFinancialRepository
{
    Task<List<IncomeReport>> GetDataAsync(string symbol);
}