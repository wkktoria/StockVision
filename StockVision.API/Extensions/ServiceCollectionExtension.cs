using StockVision.API.DelegatingHandlers;
using StockVision.Core.Domain.Constants;
using StockVision.Core.Domain.Interfaces.Repositories;
using StockVision.Core.Domain.Options;
using StockVision.Infrastructure.Repositories;

namespace StockVision.API.Extensions;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddTransient<IFinancialRepository, FinancialRepository>();

        return services;
    }

    public static IServiceCollection AddClients(this IServiceCollection services, IConfiguration configuration)
    {
        var financialModelingPrepOptions = configuration
            .GetSection(nameof(FinancialModelingPrepOptions))
            .Get<FinancialModelingPrepOptions>();

        if (financialModelingPrepOptions == null)
        {
            throw new NullReferenceException("Options for Financial Modeling Prep are missing");
        }

        services.AddHttpClient(HttpClientName.FinancialModeling, options =>
            {
                options.BaseAddress = new Uri(financialModelingPrepOptions.ApiUrl);
                options.Timeout = TimeSpan.FromSeconds(10);
            }).AddHttpMessageHandler(() => new ApiKeyHandler(financialModelingPrepOptions.ApiKey))
            .AddHttpMessageHandler(() => new LimitResponseHandler(financialModelingPrepOptions.Limit));

        return services;
    }
}