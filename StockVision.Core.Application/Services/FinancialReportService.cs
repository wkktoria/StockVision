using System.Reflection;
using StockVision.Core.Domain.Interfaces.Services;
using StockVision.Core.Domain.Models;
using StockVision.Core.Domain.Responses;

namespace StockVision.Core.Application.Services;

public class FinancialReportService(IServiceProvider serviceProvider) : IFinancialReportService
{
    public async Task PrepareFinancialReportAsync(string symbol)
    {
        var financialReport = new Dictionary<int, ReportIndicator>();
        await HandleAndFillPeriodicReportsAsync(financialReport, symbol);
        MakeCalculations(financialReport);
    }

    private void MakeCalculations(Dictionary<int, ReportIndicator> financialReport)
    {
        foreach (var reportIndicator in financialReport)
        {
            foreach (var singleIndicator in reportIndicator.Value.IndicatorsData)
            {
                singleIndicator.ProcessIndicator();
            }
        }
    }

    private async Task HandleAndFillPeriodicReportsAsync(Dictionary<int, ReportIndicator> financialReport,
        string symbol)
    {
        var periodicReportClasses = GetClassesByBaseModel(typeof(ApiReportBase));

        foreach (var periodicReportClass in periodicReportClasses)
        {
            await ProcessPeriodicReportAsync(periodicReportClass, symbol, financialReport);
        }
    }

    private async Task ProcessPeriodicReportAsync(Type periodicReportClass, string symbol,
        Dictionary<int, ReportIndicator> financialReport)
    {
        var service = GetGenericIndicatorReportService(typeof(IIndicatorReportPeriodicService<>), periodicReportClass);

        if (service != null)
        {
            var method = GetFillFormulaByPeriodicReportMethod(periodicReportClass);

            if (method != null)
            {
                await InvokeFillFormulaMethodAsync(method, service, symbol, financialReport);
            }
        }
    }

    private async Task InvokeFillFormulaMethodAsync(MethodInfo method, object service, string symbol,
        Dictionary<int, ReportIndicator> financialReport)
    {
        var task = (Task)method.Invoke(service, [symbol, financialReport]);
        await task;
    }

    private static MethodInfo? GetFillFormulaByPeriodicReportMethod(Type periodicReportClass)
    {
        var genericServiceType = typeof(IIndicatorReportPeriodicService<>).MakeGenericType(periodicReportClass);
        var method = genericServiceType
            .GetMethod(nameof(IIndicatorReportPeriodicService<ApiReportBase>.FillFormulaByPeriodicReportAsync));
        return method;
    }

    private object? GetGenericIndicatorReportService(Type interfaceType, Type periodicReportClass)
    {
        var genericServiceType = interfaceType.MakeGenericType(periodicReportClass);
        var service = serviceProvider.GetService(genericServiceType);
        return service;
    }

    private static List<Type> GetClassesByBaseModel(Type type) => AppDomain.CurrentDomain.GetAssemblies()
        .SelectMany(assembly => assembly.GetTypes())
        .Where(t => t.IsSubclassOf(type))
        .ToList();
}