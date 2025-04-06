using StockVision.Core.Domain.Models;
using StockVision.Core.Domain.Responses;

namespace StockVision.Core.Domain.Interfaces.Services;

public interface IIndicatorCommonReportService<T> where T : CommonReportBase
{
    Task FillCompanyInfoByCommonReportData(string symbol, CompanyInfo companyInfo);
}