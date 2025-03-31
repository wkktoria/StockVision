using System.Text.Json.Serialization;
using StockVision.Core.Domain.Responses;
using StockVision.Infrastructure.Attributes;
using StockVision.Infrastructure.Constants;

namespace StockVision.Infrastructure.Responses;

[ApiEndpoint(Endpoint = FinancialModelingRequest.IncomeReport)]
public class IncomeReport : ApiReportBase
{
    [JsonPropertyName("date")] public DateTime Date { get; set; }

    [JsonPropertyName("symbol")] public string Symbol { get; set; }

    [JsonPropertyName("reportedCurrency")] public string ReportedCurrency { get; set; }

    [JsonPropertyName("cik")] public string Cik { get; set; }

    [JsonPropertyName("filingDate")] public DateTime FilingDate { get; set; }

    [JsonPropertyName("period")] public string Period { get; set; }

    [JsonPropertyName("revenue")] public double Revenue { get; set; }

    [JsonPropertyName("costOfRevenue")] public double CostOfRevenue { get; set; }

    [JsonPropertyName("grossProfit")] public double GrossProfit { get; set; }

    [JsonPropertyName("researchAndDevelopmentExpenses")]
    public double ResearchAndDevelopmentExpenses { get; set; }

    [JsonPropertyName("generalAndAdministrativeExpenses")]
    public double GeneralAndAdministrativeExpenses { get; set; }

    [JsonPropertyName("sellingAndMarketingExpenses")]
    public double SellingAndMarketingExpenses { get; set; }

    [JsonPropertyName("sellingGeneralAndAdministrativeExpenses")]
    public double SellingGeneralAndAdministrativeExpenses { get; set; }

    [JsonPropertyName("otherExpenses")] public double OtherExpenses { get; set; }

    [JsonPropertyName("operatingExpenses")]
    public double OperatingExpenses { get; set; }

    [JsonPropertyName("costAndExpenses")] public double CostAndExpenses { get; set; }

    [JsonPropertyName("netInterestIncome")]
    public double NetInterestIncome { get; set; }

    [JsonPropertyName("interestIncome")] public double InterestIncome { get; set; }

    [JsonPropertyName("interestExpense")] public double InterestExpense { get; set; }

    [JsonPropertyName("depreciationAndAmortization")]
    public double DepreciationAndAmortization { get; set; }

    [JsonPropertyName("ebitda")] public double Ebitda { get; set; }

    [JsonPropertyName("ebit")] public double Ebit { get; set; }

    [JsonPropertyName("nonOperatingIncomeExcludingInterest")]
    public double NonOperatingIncomeExcludingInterest { get; set; }

    [JsonPropertyName("operatingIncome")] public double OperatingIncome { get; set; }

    [JsonPropertyName("totalOtherIncomeExpensesNet")]
    public double TotalOtherIncomeExpensesNet { get; set; }

    [JsonPropertyName("incomeBeforeTax")] public double IncomeBeforeTax { get; set; }

    [JsonPropertyName("incomeTaxExpense")] public double IncomeTaxExpense { get; set; }

    [JsonPropertyName("netIncomeFromContinuingOperations")]
    public double NetIncomeFromContinuingOperations { get; set; }

    [JsonPropertyName("netIncomeFromDiscontinuedOperations")]
    public double NetIncomeFromDiscontinuedOperations { get; set; }

    [JsonPropertyName("otherAdjustmentsToNetIncome")]
    public double OtherAdjustmentsToNetIncome { get; set; }

    [JsonPropertyName("netIncome")] public double NetIncome { get; set; }

    [JsonPropertyName("netIncomeDeductions")]
    public double NetIncomeDeductions { get; set; }

    [JsonPropertyName("bottomLineNetIncome")]
    public double BottomLineNetIncome { get; set; }

    [JsonPropertyName("eps")] public double Eps { get; set; }

    [JsonPropertyName("epsDiluted")] public double EpsDiluted { get; set; }

    [JsonPropertyName("weightedAverageShsOut")]
    public double WeightedAverageShsOut { get; set; }

    [JsonPropertyName("weightedAverageShsOutDil")]
    public double WeightedAverageShsOutDil { get; set; }
}