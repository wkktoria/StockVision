using Microsoft.Extensions.Options;
using StockVision.Core.Domain.Interfaces.Repositories;
using StockVision.Core.Domain.Interfaces.Services;
using StockVision.Core.Domain.Models;
using StockVision.Core.Domain.Options;
using StockVision.Core.Domain.Responses;

namespace StockVision.Core.Application.Services;

public class IndicatorCommonReportService<T>(
    IFinancialReportRepository<T> financialReportService,
    IOptions<ReportIndicatorOptions> reportIndicatorOptions)
    : IIndicatorCommonReportService<T> where T : CommonReportBase
{
    private readonly ReportIndicatorOptions _reportIndicatorOptions = reportIndicatorOptions.Value;

    public async Task FillCompanyInfoByCommonReportData(string symbol, CompanyInfo companyInfo)
    {
        var reportData = await financialReportService.GetDataAsync(symbol);
        var singleReport = reportData.FirstOrDefault();

        if (singleReport == null)
        {
            return;
        }

        MapCompanyInfoOptionsToDomain(companyInfo);
    }

    private void MapCompanyInfoOptionsToDomain(CompanyInfo companyInfo)
    {
        var companyInfoOptions = _reportIndicatorOptions.CompanyInfo;
        companyInfo.UpdateCompanyInfo(
            companyInfoOptions.Name,
            companyInfoOptions.Sector,
            companyInfoOptions.Symbol,
            companyInfoOptions.Exchange,
            companyInfoOptions.StockPrice);
    }
}