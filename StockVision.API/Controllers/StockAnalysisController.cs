using Microsoft.AspNetCore.Mvc;
using StockVision.Core.Domain.Interfaces.Repositories;
using StockVision.Core.Domain.Interfaces.Services;
using StockVision.Infrastructure.Responses;

namespace StockVision.API.Controllers;

[ApiController]
[Route("[controller]")]
public class StockAnalysisController(IIndicatorReportPeriodicService<CashFlowReport> financialService)
    : Controller
{
    [HttpGet(Name = "GetCompanyReportInfo")]
    public async Task<JsonResult> Get([FromQuery] string symbol)
    {
        await financialService.FillFormulaByPeriodicReportAsync(symbol);
        return Json("");
    }
}