using System.Text.Json.Serialization;

namespace StockVision.Core.Domain.Responses;

public class PeriodicReportBase : ApiReportBase
{
    [JsonPropertyName("date")] public DateTime Date { get; set; }
}