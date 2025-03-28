using System.Text.Json.Serialization;

namespace StockVision.Core.Domain.Responses;

public class BalanceReport
{
    [JsonPropertyName("date")] public DateTime Date { get; set; }

    [JsonPropertyName("symbol")] public string Symbol { get; set; }

    [JsonPropertyName("reportedCurrency")] public string ReportedCurrency { get; set; }

    [JsonPropertyName("cik")] public string Cik { get; set; }

    [JsonPropertyName("filingDate")] public DateTime FilingDate { get; set; }

    [JsonPropertyName("period")] public string Period { get; set; }

    [JsonPropertyName("cashAndCashEquivalents")]
    public double CashAndCashEquivalents { get; set; }

    [JsonPropertyName("shortTermInvestments")]
    public double ShortTermInvestments { get; set; }

    [JsonPropertyName("cashAndShortTermInvestments")]
    public double CashAndShortTermInvestments { get; set; }

    [JsonPropertyName("netReceivables")] public double NetReceivables { get; set; }

    [JsonPropertyName("accountsReceivables")]
    public double AccountsReceivables { get; set; }

    [JsonPropertyName("otherReceivables")] public double OtherReceivables { get; set; }

    [JsonPropertyName("inventory")] public double Inventory { get; set; }

    [JsonPropertyName("prepaids")] public double Prepaids { get; set; }

    [JsonPropertyName("otherCurrentAssets")]
    public double OtherCurrentAssets { get; set; }

    [JsonPropertyName("totalCurrentAssets")]
    public double TotalCurrentAssets { get; set; }

    [JsonPropertyName("propertyPlantEquipmentNet")]
    public double PropertyPlantEquipmentNet { get; set; }

    [JsonPropertyName("goodwill")] public double Goodwill { get; set; }

    [JsonPropertyName("intangibleAssets")] public double IntangibleAssets { get; set; }

    [JsonPropertyName("goodwillAndIntangibleAssets")]
    public double GoodwillAndIntangibleAssets { get; set; }

    [JsonPropertyName("doubleTermInvestments")]
    public double doubleTermInvestments { get; set; }

    [JsonPropertyName("taxAssets")] public double TaxAssets { get; set; }

    [JsonPropertyName("otherNonCurrentAssets")]
    public double OtherNonCurrentAssets { get; set; }

    [JsonPropertyName("totalNonCurrentAssets")]
    public double TotalNonCurrentAssets { get; set; }

    [JsonPropertyName("otherAssets")] public double OtherAssets { get; set; }

    [JsonPropertyName("totalAssets")] public double TotalAssets { get; set; }

    [JsonPropertyName("totalPayables")] public double TotalPayables { get; set; }

    [JsonPropertyName("accountPayables")] public double AccountPayables { get; set; }

    [JsonPropertyName("otherPayables")] public double OtherPayables { get; set; }

    [JsonPropertyName("accruedExpenses")] public double AccruedExpenses { get; set; }

    [JsonPropertyName("shortTermDebt")] public double ShortTermDebt { get; set; }

    [JsonPropertyName("capitalLeaseObligationsCurrent")]
    public double CapitalLeaseObligationsCurrent { get; set; }

    [JsonPropertyName("taxPayables")] public double TaxPayables { get; set; }

    [JsonPropertyName("deferredRevenue")] public double DeferredRevenue { get; set; }

    [JsonPropertyName("otherCurrentLiabilities")]
    public double OtherCurrentLiabilities { get; set; }

    [JsonPropertyName("totalCurrentLiabilities")]
    public double TotalCurrentLiabilities { get; set; }

    [JsonPropertyName("doubleTermDebt")] public double doubleTermDebt { get; set; }

    [JsonPropertyName("capitalLeaseObligationsNonCurrent")]
    public double CapitalLeaseObligationsNonCurrent { get; set; }

    [JsonPropertyName("deferredRevenueNonCurrent")]
    public double DeferredRevenueNonCurrent { get; set; }

    [JsonPropertyName("deferredTaxLiabilitiesNonCurrent")]
    public double DeferredTaxLiabilitiesNonCurrent { get; set; }

    [JsonPropertyName("otherNonCurrentLiabilities")]
    public double OtherNonCurrentLiabilities { get; set; }

    [JsonPropertyName("totalNonCurrentLiabilities")]
    public double TotalNonCurrentLiabilities { get; set; }

    [JsonPropertyName("otherLiabilities")] public double OtherLiabilities { get; set; }

    [JsonPropertyName("capitalLeaseObligations")]
    public double CapitalLeaseObligations { get; set; }

    [JsonPropertyName("totalLiabilities")] public double TotalLiabilities { get; set; }

    [JsonPropertyName("treasuryStock")] public double TreasuryStock { get; set; }

    [JsonPropertyName("preferredStock")] public double PreferredStock { get; set; }

    [JsonPropertyName("commonStock")] public double CommonStock { get; set; }

    [JsonPropertyName("retainedEarnings")] public double RetainedEarnings { get; set; }

    [JsonPropertyName("additionalPaidInCapital")]
    public double AdditionalPaidInCapital { get; set; }

    [JsonPropertyName("accumulatedOtherComprehensiveIncomeLoss")]
    public double AccumulatedOtherComprehensiveIncomeLoss { get; set; }

    [JsonPropertyName("otherTotalStockholdersEquity")]
    public double OtherTotalStockholdersEquity { get; set; }

    [JsonPropertyName("totalStockholdersEquity")]
    public double TotalStockholdersEquity { get; set; }

    [JsonPropertyName("totalEquity")] public double TotalEquity { get; set; }

    [JsonPropertyName("minorityInterest")] public double MinorityInterest { get; set; }

    [JsonPropertyName("totalLiabilitiesAndTotalEquity")]
    public double TotalLiabilitiesAndTotalEquity { get; set; }

    [JsonPropertyName("totalInvestments")] public double TotalInvestments { get; set; }

    [JsonPropertyName("totalDebt")] public double TotalDebt { get; set; }

    [JsonPropertyName("netDebt")] public double NetDebt { get; set; }
}