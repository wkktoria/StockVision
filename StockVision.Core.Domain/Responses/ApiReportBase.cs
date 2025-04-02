using System.Text.Json.Serialization;

namespace StockVision.Core.Domain.Responses;

public abstract class ApiReportBase
{
    [JsonPropertyName("date")] public DateTime Date { get; set; }
}