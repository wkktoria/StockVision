using System.Reflection;
using DynamicExpresso;
using StockVision.Core.Domain.Responses;

namespace StockVision.Core.Domain.Models;

public class Indicator(
    string name,
    string value,
    string topRange,
    string middleTopRange,
    string middleBottomRange,
    string bottomRange,
    string note)
{
    public string Name { get; private set; } = name;

    public string Value { get; private set; } = value;

    public string TopRange { get; private set; } = topRange;

    public string MiddleTopRange { get; private set; } = middleTopRange;

    public string MiddleBottomRange { get; private set; } = middleBottomRange;

    public string BottomRange { get; private set; } = bottomRange;

    public string Note { get; private set; } = note;

    public void ReplaceIndicatorByReportData<T>(T singleReport) where T : PeriodicReportBase
    {
        var type = singleReport.GetType();
        var properties = type.GetProperties();
        var formula = Value;

        foreach (var property in properties)
        {
            var propertyFormula = $"{type.Name}.{property.Name}";
            var value = GetValueForProperty(singleReport, property);
            formula = formula.Replace(propertyFormula, value);
        }

        Value = formula;
    }

    public void ProcessIndicator()
    {
        try
        {
            var interpreter = new Interpreter();
            var value = interpreter.Eval<double>(Value).ToString("F2");
            SetValue(value);
        }
        catch
        {
            SetValue("error");
        }
    }

    private static string GetValueForProperty<T>(T singleReport, PropertyInfo property) where T : PeriodicReportBase
    {
        var propertyValue = property.GetValue(singleReport)?.ToString() ?? string.Empty;

        if (propertyValue.Contains(',') || propertyValue.Contains('.'))
        {
            return propertyValue.Replace(',', '.');
        }

        return $"{propertyValue}.0";
    }

    private void SetValue(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new ArgumentException("Indicator value cannot be empty");
        }

        Value = value;
    }
}