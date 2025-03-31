namespace StockVision.Infrastructure.Constants;

public static class FinancialModelingRequest
{
    public const string IncomeReport = "income-statement?symbol={0}";
    public const string BalanceReport = "balance-sheet-statement?symbol={0}";
    public const string CashFlowReport = "cash-flow-statement?symbol={0}";
}