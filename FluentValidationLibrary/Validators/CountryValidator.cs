using FluentValidation;
using FluentValidationLibrary.Extensions;
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

    public class WeekendDateNotPermitted : AbstractValidator<Customer>
    {
        public WeekendDateNotPermitted()
        {
            RuleFor(customer => customer.AppointmentDate.IsNotWeekend());
        }
    }
}
