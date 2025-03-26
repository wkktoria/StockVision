using System.Net.Http.Json;
using Microsoft.Extensions.Logging;
using StockVision.Core.Domain.Constants;
using StockVision.Core.Domain.Interfaces.Repositories;
using StockVision.Core.Domain.Responses;
using StockVision.Infrastructure.Constants;

namespace StockVision.Infrastructure.Repositories;

public class FinancialRepository(IHttpClientFactory httpClientFactory, ILogger<FinancialRepository> logger)
    : IFinancialRepository
{
    private readonly HttpClient _httpClient = httpClientFactory.CreateClient(HttpClientName.FinancialModeling);

    public async Task<List<IncomeReport>> GetDataAsync(string symbol)
    {
        try
        {
            var requestResult =
                await _httpClient.GetAsync(FinancialModelingRequest.IncomeReport.Replace("<SYMBOL>", symbol));

            if (!requestResult.IsSuccessStatusCode)
            {
                throw new Exception("Error while retrieving data from external API");
            }

            var resul = await requestResult.Content.ReadFromJsonAsync<List<IncomeReport>>();
            return resul ?? [];
        }
        catch (Exception ex)
        {
            var errorMessae = "Error while retrieving data from external API";
            logger.LogError(ex, errorMessae);
            throw new Exception(errorMessae);
        }
    }
}