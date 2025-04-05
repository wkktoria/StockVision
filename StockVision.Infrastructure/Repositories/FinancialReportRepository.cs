using System.Net.Http.Json;
using System.Runtime.InteropServices;
using Microsoft.Extensions.Logging;
using StockVision.Core.Domain.Constants;
using StockVision.Core.Domain.Exceptions;
using StockVision.Core.Domain.Interfaces.Repositories;
using StockVision.Core.Domain.Responses;
using StockVision.Infrastructure.Attributes;

namespace StockVision.Infrastructure.Repositories;

public class FinancialReportRepository<T>(
    IHttpClientFactory httpClientFactory,
    ILogger<FinancialReportRepository<T>> logger)
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

            ValidRequestResult(requestResult, symbol);

            var result = await requestResult.Content.ReadFromJsonAsync<List<T>>();
            return result ?? [];
        }
        catch (ExternalServiceException ex)
        {
            logger.LogError(ex, $"Error while retrieving data from external API. Symbol: {symbol}");
            throw;
        }
    }

    private void ValidRequestResult(HttpResponseMessage requestResult, string symbol)
    {
        if (requestResult.IsSuccessStatusCode) return;

        var errorMessage =
            $"Error while retrieving data from external API. Status code: {requestResult.StatusCode}, symbol: {symbol}";
        logger.LogError(errorMessage);
        throw new ExternalException(errorMessage);
    }

    private string GetEndpoint()
    {
        var type = typeof(T);
        var attribute = type.GetCustomAttributes(typeof(ApiEndpointAttribute), false)
            .FirstOrDefault() as ApiEndpointAttribute;

        if (attribute != null)
        {
            return attribute.Endpoint;
        }

        logger.LogError($"Response model {typeof(T).Name} does not have defined {nameof(ApiEndpointAttribute)}");
        throw new ApplicationException("An internal system error has occured");
    }
}