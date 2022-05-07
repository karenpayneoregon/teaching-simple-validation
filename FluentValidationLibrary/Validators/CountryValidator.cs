using FluentValidation;
using FluentValidationLibrary.Models;


namespace FluentValidationLibrary.Validators
{
    public class CountryValidator : AbstractValidator<Country>
    {
        public CountryValidator()
        {
            RuleFor(country => country).NotNull();
        }
    }
}
