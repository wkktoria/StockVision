using System.Net.Http.Json;
using Microsoft.Extensions.Logging;
using StockVision.Core.Domain.Constants;
using StockVision.Core.Domain.Interfaces.Repositories;
using StockVision.Core.Domain.Responses;
using StockVision.Infrastructure.Attributes;

namespace StockVision.Infrastructure.Repositories;

public class FinancialReportReportRepository<T>(
    IHttpClientFactory httpClientFactory,
    ILogger<FinancialReportReportRepository<T>> logger)
    : IFinancialReportRepository<T> where T : ApiReportBase
{
    private readonly HttpClient _httpClient = httpClientFactory.CreateClient(HttpClientName.FinancialModeling);

    public async Task<List<T>> GetDataAsync(string symbol)
    {
        try
        {
            var endpoint = GetEndpoint();
            var requestResult =
                await _httpClient.GetAsync(string.Format(endpoint, symbol));

            if (!requestResult.IsSuccessStatusCode)
            {
                throw new Exception("Error while retrieving data from external API");
            }

            var result = await requestResult.Content.ReadFromJsonAsync<List<T>>();
            return result ?? [];
        }
        catch (Exception ex)
        {
            const string errorMessage = "Error while retrieving data from external API";
            logger.LogError(ex, errorMessage);
            throw new Exception(errorMessage);
        }
    }

    private string GetEndpoint()
    {
        var type = typeof(T);
        var attribute = type.GetCustomAttributes(typeof(ApiEndpointAttribute), false)
            .FirstOrDefault() as ApiEndpointAttribute;

        if (attribute == null)
        {
            throw new ApplicationException("An internal system error has occured");
        }

        return attribute.Endpoint;
    }
}