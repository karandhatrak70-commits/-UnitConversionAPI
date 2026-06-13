using FluentValidation;
using UnitConversionApi.Models;

namespace UnitConversionApi.Validators;

public class ConversionRequestValidator : AbstractValidator<ConversionRequest>
{
    public ConversionRequestValidator()
    {
        RuleFor(x => x.Value)
            .NotNull();

        RuleFor(x => x.Category)
            .NotEmpty();

        RuleFor(x => x.FromUnit)
            .NotEmpty();

        RuleFor(x => x.ToUnit)
            .NotEmpty();
    }
}