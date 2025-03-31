using System.Text.Json.Serialization;
using StockVision.Core.Domain.Responses;
using StockVision.Infrastructure.Attributes;
using StockVision.Infrastructure.Constants;

namespace StockVision.Infrastructure.Responses;

[ApiEndpoint(Endpoint = FinancialModelingRequest.CashFlowReport)]
public class CashFlowReport : ApiReportBase
{
    [JsonPropertyName("date")] public DateTime Date { get; set; }

    [JsonPropertyName("symbol")] public string Symbol { get; set; }

    [JsonPropertyName("reportedCurrency")] public string ReportedCurrency { get; set; }

    [JsonPropertyName("cik")] public string Cik { get; set; }

    [JsonPropertyName("filingDate")] public DateTime FilingDate { get; set; }

    [JsonPropertyName("period")] public string Period { get; set; }

    [JsonPropertyName("netIncome")] public double NetIncome { get; set; }

    [JsonPropertyName("depreciationAndAmortization")]
    public double DepreciationAndAmortization { get; set; }

    [JsonPropertyName("deferredIncomeTax")]
    public double DeferredIncomeTax { get; set; }

    [JsonPropertyName("stockBasedCompensation")]
    public double StockBasedCompensation { get; set; }

    [JsonPropertyName("changeInWorkingCapital")]
    public double ChangeInWorkingCapital { get; set; }

    [JsonPropertyName("accountsReceivables")]
    public double AccountsReceivables { get; set; }

    [JsonPropertyName("inventory")] public double Inventory { get; set; }

    [JsonPropertyName("accountsPayables")] public double AccountsPayables { get; set; }

    [JsonPropertyName("otherWorkingCapital")]
    public double OtherWorkingCapital { get; set; }

    [JsonPropertyName("otherNonCashItems")]
    public double OtherNonCashItems { get; set; }

    [JsonPropertyName("netCashProvidedByOperatingActivities")]
    public double NetCashProvidedByOperatingActivities { get; set; }

    [JsonPropertyName("investmentsInPropertyPlantAndEquipment")]
    public double InvestmentsInPropertyPlantAndEquipment { get; set; }

    [JsonPropertyName("acquisitionsNet")] public double AcquisitionsNet { get; set; }

    [JsonPropertyName("purchasesOfInvestments")]
    public double PurchasesOfInvestments { get; set; }

    [JsonPropertyName("salesMaturitiesOfInvestments")]
    public double SalesMaturitiesOfInvestments { get; set; }

    [JsonPropertyName("otherInvestingActivities")]
    public double OtherInvestingActivities { get; set; }

    [JsonPropertyName("netCashProvidedByInvestingActivities")]
    public double NetCashProvidedByInvestingActivities { get; set; }

    [JsonPropertyName("netDebtIssuance")] public double NetDebtIssuance { get; set; }

    [JsonPropertyName("doubleTermNetDebtIssuance")]
    public double doubleTermNetDebtIssuance { get; set; }

    [JsonPropertyName("shortTermNetDebtIssuance")]
    public double ShortTermNetDebtIssuance { get; set; }

    [JsonPropertyName("netStockIssuance")] public double NetStockIssuance { get; set; }

    [JsonPropertyName("netCommonStockIssuance")]
    public double NetCommonStockIssuance { get; set; }

    [JsonPropertyName("commonStockIssuance")]
    public double CommonStockIssuance { get; set; }

    [JsonPropertyName("commonStockRepurchased")]
    public double CommonStockRepurchased { get; set; }

    [JsonPropertyName("netPreferredStockIssuance")]
    public double NetPreferredStockIssuance { get; set; }

    [JsonPropertyName("netDividendsPaid")] public double NetDividendsPaid { get; set; }

    [JsonPropertyName("commonDividendsPaid")]
    public double CommonDividendsPaid { get; set; }

    [JsonPropertyName("preferredDividendsPaid")]
    public double PreferredDividendsPaid { get; set; }

    [JsonPropertyName("otherFinancingActivities")]
    public double OtherFinancingActivities { get; set; }

    [JsonPropertyName("netCashProvidedByFinancingActivities")]
    public double NetCashProvidedByFinancingActivities { get; set; }

    [JsonPropertyName("effectOfForexChangesOnCash")]
    public double EffectOfForexChangesOnCash { get; set; }

    [JsonPropertyName("netChangeInCash")] public double NetChangeInCash { get; set; }

    [JsonPropertyName("cashAtEndOfPeriod")]
    public double CashAtEndOfPeriod { get; set; }

    [JsonPropertyName("cashAtBeginningOfPeriod")]
    public double CashAtBeginningOfPeriod { get; set; }

    [JsonPropertyName("operatingCashFlow")]
    public double OperatingCashFlow { get; set; }

    [JsonPropertyName("capitalExpenditure")]
    public double CapitalExpenditure { get; set; }

    [JsonPropertyName("freeCashFlow")] public double FreeCashFlow { get; set; }

    [JsonPropertyName("incomeTaxesPaid")] public double IncomeTaxesPaid { get; set; }

    [JsonPropertyName("interestPaid")] public double InterestPaid { get; set; }
}