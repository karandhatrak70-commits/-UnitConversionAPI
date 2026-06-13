namespace UnitConversionApi.Converters;

public class WeightConverter : IUnitConverter
{
    public string Category => "weight";

    private readonly Dictionary<string, double> Units = new()
    {
        { "kilogram", 1.0 },
        { "pound", 2.20462 }
    };

    public double Convert(
        double value,
        string fromUnit,
        string toUnit)
    {
        fromUnit = fromUnit.ToLower();
        toUnit = toUnit.ToLower();

        double kilograms = value / Units[fromUnit];

        return kilograms * Units[toUnit];
    }
}