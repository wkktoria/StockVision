using Microsoft.AspNetCore.Mvc;
using StockVision.Core.Domain.Interfaces.Repositories;

namespace StockVision.API.Controllers;

public class StockAnalysisController(IFinancialRepository financialRepository) : Controller
{
    [HttpGet(Name = "GetCompanyReportInfo")]
    public async Task<JsonResult> Get()
    {
        var result = await financialRepository.GetDataAsync("AAPL");
        return Json(result);
    }
}