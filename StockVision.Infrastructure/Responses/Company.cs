using System.Text.Json.Serialization;
using StockVision.Core.Domain.Responses;
using StockVision.Infrastructure.Attributes;
using StockVision.Infrastructure.Constants;

namespace StockVision.Infrastructure.Responses;

[ApiEndpoint(Endpoint = FinancialModelingRequest.CompanyReport)]
public class Company : CommonReportBase
{
    [JsonPropertyName("symbol")] public string Symbol { get; set; }

    [JsonPropertyName("price")] public double Price { get; set; }

    [JsonPropertyName("marketCap")] public long MarketCap { get; set; }

    [JsonPropertyName("beta")] public double Beta { get; set; }

    [JsonPropertyName("lastDividend")] public long LastDividend { get; set; }

    [JsonPropertyName("range")] public string Range { get; set; }

    [JsonPropertyName("change")] public double Change { get; set; }

    [JsonPropertyName("changePercentage")] public double ChangePercentage { get; set; }

    [JsonPropertyName("volume")] public long Volume { get; set; }

    [JsonPropertyName("averageVolume")] public long AverageVolume { get; set; }

    [JsonPropertyName("companyName")] public string CompanyName { get; set; }

    [JsonPropertyName("currency")] public string Currency { get; set; }

    [JsonPropertyName("cik")] public string Cik { get; set; }

    [JsonPropertyName("isin")] public string Isin { get; set; }

    [JsonPropertyName("cusip")] public string Cusip { get; set; }

    [JsonPropertyName("exchangeFullName")] public string ExchangeFullName { get; set; }

    [JsonPropertyName("exchange")] public string Exchange { get; set; }

    [JsonPropertyName("industry")] public string Industry { get; set; }

    [JsonPropertyName("website")] public Uri Website { get; set; }

    [JsonPropertyName("description")] public string Description { get; set; }

    [JsonPropertyName("ceo")] public string Ceo { get; set; }

    [JsonPropertyName("sector")] public string Sector { get; set; }

    [JsonPropertyName("country")] public string Country { get; set; }

    [JsonPropertyName("phone")] public string Phone { get; set; }

    [JsonPropertyName("address")] public string Address { get; set; }

    [JsonPropertyName("city")] public string City { get; set; }

    [JsonPropertyName("state")] public string State { get; set; }

    [JsonPropertyName("image")] public Uri Image { get; set; }

    [JsonPropertyName("ipoDate")] public DateTimeOffset IpoDate { get; set; }

    [JsonPropertyName("defaultImage")] public bool DefaultImage { get; set; }

    [JsonPropertyName("isEtf")] public bool IsEtf { get; set; }

    [JsonPropertyName("isActivelyTrading")]
    public bool IsActivelyTrading { get; set; }

    [JsonPropertyName("isAdr")] public bool IsAdr { get; set; }

    [JsonPropertyName("isFund")] public bool IsFund { get; set; }
}