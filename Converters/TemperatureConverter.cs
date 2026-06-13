namespace UnitConversionApi.Converters;

public class TemperatureConverter : IUnitConverter
{
    public string Category => "temperature";

    public double Convert(
        double value,
        string fromUnit,
        string toUnit)
    {
        fromUnit = fromUnit.ToLower();
        toUnit = toUnit.ToLower();

        if (fromUnit == toUnit)
            return value;

        if (fromUnit == "celsius" &&
            toUnit == "fahrenheit")
        {
            return (value * 9 / 5) + 32;
        }

        if (fromUnit == "fahrenheit" &&
            toUnit == "celsius")
        {
            return (value - 32) * 5 / 9;
        }

        throw new Exception(
            "Unsupported temperature conversion.");
    }
}