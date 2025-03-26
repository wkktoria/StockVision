using System.Net.Http.Json;
using StockVision.Core.Domain.Interfaces.Repositories;
using StockVision.Core.Domain.Responses;

namespace StockVision.Infrastructure.Repositories;

public class FinancialRepository(IHttpClientFactory httpClientFactory) : IFinancialRepository
{
    private readonly HttpClient _httpClient = httpClientFactory.CreateClient("FinancialModelingPrep");

    public async Task<List<IncomeReport>> GetDataAsync(string symbol)
    {
        var requestResult = await _httpClient.GetAsync($"income-statement?symbol={symbol}");

        if (!requestResult.IsSuccessStatusCode)
        {
            throw new Exception("Error while retrieving data from external API");
        }

        var resul = await requestResult.Content.ReadFromJsonAsync<List<IncomeReport>>();
        return resul ?? [];
    }
}