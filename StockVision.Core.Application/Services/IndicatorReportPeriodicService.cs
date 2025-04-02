using Microsoft.Extensions.Options;
using StockVision.Core.Domain.Interfaces.Repositories;
using StockVision.Core.Domain.Interfaces.Services;
using StockVision.Core.Domain.Models;
using StockVision.Core.Domain.Options;
using StockVision.Core.Domain.Responses;

namespace StockVision.Core.Application.Services;

public class IndicatorReportPeriodicService<T>(
    IFinancialReportRepository<T> financialReportRepository,
    IOptions<ReportIndicatorOptions> reportIndicatorOptions)
    : IIndicatorReportPeriodicService<T>
    where T : ApiReportBase
{
    private readonly ReportIndicatorOptions _reportIndicatorOptions = reportIndicatorOptions.Value;

    public async Task FillFormulaByPeriodicReportAsync(string symbol)
    {
        var resultDictionary = new Dictionary<int, ReportIndicator>();
        var reportData = await financialReportRepository.GetDataAsync(symbol);
        ProcessReportAndUpdateIndicator(reportData, resultDictionary);
    }

    private void ProcessReportAndUpdateIndicator(List<T> reportData, Dictionary<int, ReportIndicator> resultDictionary)
    {
        foreach (var singleReport in reportData)
        {
            var reportIndicator = MapIndicatorOptionsToDomain();
            resultDictionary.Add(singleReport.Date.Year, reportIndicator);
            ReplaceFormula(reportIndicator, singleReport);
        }
    }

    private void ReplaceFormula(ReportIndicator reportIndicatorData, T singleReport)
    {
        foreach (var reportIndicator in reportIndicatorData.IndicatorsData)
        {
            reportIndicator.ReplaceIndicatorByReportData(singleReport);
        }
    }

    private ReportIndicator MapIndicatorOptionsToDomain()
    {
        var reportIndicator = new ReportIndicator();
        
        foreach (var reportIndicatorInfo in _reportIndicatorOptions.IndicatorsInfo)
        {
            var indicator = new Indicator
            (
                reportIndicatorInfo.Name,
                reportIndicatorInfo.Formula,
                reportIndicatorInfo.TopRange,
                reportIndicatorInfo.MiddleTopRange,
                reportIndicatorInfo.MiddleBottomRange,
                reportIndicatorInfo.BottomRange,
                reportIndicatorInfo.Note
            );
            reportIndicator.IndicatorsData.Add(indicator);
        }

        return reportIndicator;
    }
}