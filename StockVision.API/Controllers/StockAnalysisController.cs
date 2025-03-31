using Microsoft.AspNetCore.Mvc;
using StockVision.Core.Domain.Interfaces.Repositories;
using StockVision.Infrastructure.Responses;

namespace StockVision.API.Controllers;

[ApiController]
[Route("[controller]")]
public class StockAnalysisController(IFinancialReportRepository<IncomeReport> financialReportRepository) : Controller
{
    [HttpGet(Name = "GetCompanyReportInfo")]
    public async Task<JsonResult> Get([FromQuery] string symbol)
    {
        var result = await financialReportRepository.GetDataAsync(symbol);
        return Json(result);
    }
}