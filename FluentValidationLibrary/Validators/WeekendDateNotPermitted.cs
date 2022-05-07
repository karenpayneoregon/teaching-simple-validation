using FluentValidation;
using FluentValidationLibrary.Extensions;
using FluentValidationLibrary.Models;

namespace FluentValidationLibrary.Validators
{
    public class WeekendDateNotPermitted : AbstractValidator<Customer>
    {
        public WeekendDateNotPermitted()
        {
            RuleFor(customer => customer.AppointmentDate.IsNotWeekend());
        }
    }
}