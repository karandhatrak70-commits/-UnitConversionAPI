namespace UnitConversionApi.Converters;

public class LengthConverter : IUnitConverter
{
    public string Category => "length";

    private readonly Dictionary<string, double> Units = new()
    {
        { "meter", 1.0 },
        { "foot", 3.28084 },
        { "kilometer", 0.001 }
    };

    public double Convert(
        double value,
        string fromUnit,
        string toUnit)
    {
        fromUnit = fromUnit.ToLower();
        toUnit = toUnit.ToLower();

        double meters = value / Units[fromUnit];

        return meters * Units[toUnit];
    }
}