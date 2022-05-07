using FluentValidation;
using FluentValidation.Results;
using FluentValidationLibrary.Classes;
using FluentValidationLibrary.Extensions;
using FluentValidationLibrary.Models;


namespace FluentValidationLibrary.Validators
{
    /// <summary>
    /// Provides validation rules for a <see cref="Customer"/> which also
    /// relies on <see cref="CountryValidator"/> for <see cref="Country"/> property CountryName.
    ///
    /// Various rules like <see cref="Customer.PostalCode"/> are hard-coded which could come
    /// from a data source.
    /// </summary>
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            var settings = SettingsOperations.ReadCustomerSettings();

            RuleFor(customer => customer.FirstName)
                .NotEmpty()
                .MinimumLength(settings.FirstNameSettings.MinimumLength)
                .MaximumLength(settings.FirstNameSettings.MaximumLength)
                .WithName(settings.FirstNameSettings.WithName);

            RuleFor(customer => customer.LastName)
                .NotEmpty()
                .MinimumLength(settings.LastNameSettings.MinimumLength)
                .MaximumLength(settings.LastNameSettings.MaximumLength)
                .WithName(settings.LastNameSettings.WithName);

            RuleFor(customer => customer.NotesList)
                .ListMustContainFewerThan(5);

            RuleFor(customer => customer.CreditCardNumber)
                .CreditCard();

            RuleFor(customer => customer.Pin)
                .Length(4)
                .Must(pin => pin.HaveValidPin());

            RuleFor(customer => customer.Country)
                .NotNull();

            RuleFor(customer => customer.Country.CountryName)
                .NotEqual("Select")
                .WithMessage("Please select a country");

            RuleFor(customer => customer.Country).SetValidator(new CountryValidator());
            
            RuleFor(customer => customer.BirthDate.Year)
                .NotNull()
                .LessThan(2021).GreaterThan(1931);

            Transform(
                from: customer => customer.SocialSecurity,
                to: value => value.IsSocialSecurityNumberValid()).Must(value => value)
                .WithMessage("SSN not acceptable");

            Transform(
                    from: customer => customer.PostalCode,
                    to: value => value.HasValidPostcode()).Must(value => value)
                .WithMessage("Required a valid postal code");

            RuleFor(customer => customer.AppointmentDate)
                .Must(dateTime => dateTime.IsNotWeekend())
                .WithName("Appointment date")
                .WithMessage("We are not open on weekends");

        }

        protected override bool PreValidate(ValidationContext<Customer> context, ValidationResult result)
        {
            if (context.InstanceToValidate is null)
            {
                result.Errors.Add(new ValidationFailure("", $"Dude, must have a none null instance of {nameof(Customer)}"));
                return false;
            }

            //                                        👇
            if (context.InstanceToValidate.Country is null)
            {//                                                                                                       👇
                result.Errors.Add(new ValidationFailure("", $"Dude, {nameof(Customer.Country)} can not be null"));
                return false;
            }

            return true;
        }
    }
}
