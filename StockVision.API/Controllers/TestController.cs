using Microsoft.AspNetCore.Mvc;
using StockVision.Core.Domain.Interfaces.Repositories;

namespace StockVision.API.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController(IFinancialRepository financialRepository, ILogger<TestController> logger) : Controller
{
    [HttpGet]
    public async Task<JsonResult> Get()
    {
        var result = await financialRepository.GetDataAsync("AAPL");
        return Json(result);
    }
}