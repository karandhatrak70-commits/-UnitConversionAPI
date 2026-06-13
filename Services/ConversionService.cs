using UnitConversionApi.Converters;

namespace UnitConversionApi.Services;

public class ConversionService : IConversionService
{
    private readonly IEnumerable<IUnitConverter> _converters;

    public ConversionService(
        IEnumerable<IUnitConverter> converters)
    {
        _converters = converters;
    }

    public double Convert(
        string category,
        string fromUnit,
        string toUnit,
        double value)
    {
        var converter = _converters.FirstOrDefault(
            c => c.Category.Equals(
                category,
                StringComparison.OrdinalIgnoreCase));

        if (converter == null)
        {
            throw new Exception(
                $"Unsupported category: {category}");
        }

        return converter.Convert(
            value,
            fromUnit,
            toUnit);
    }
}