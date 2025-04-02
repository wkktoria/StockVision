namespace StockVision.Core.Domain.Options;

public class ReportIndicatorOptions
{
    public List<IndicatorOptions> IndicatorsInfo { get; set; } = [];

    public class IndicatorOptions
    {
        public string Name { get; set; } = string.Empty;

        public string Formula { get; set; } = string.Empty;

        public string TopRange { get; set; } = string.Empty;

        public string MiddleTopRange { get; set; } = string.Empty;

        public string MiddleBottomRange { get; set; } = string.Empty;

        public string BottomRange { get; set; } = string.Empty;

        public string Note { get; set; } = string.Empty;
    }
}