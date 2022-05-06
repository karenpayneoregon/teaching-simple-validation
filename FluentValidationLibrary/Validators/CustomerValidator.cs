using System.Security.Cryptography.X509Certificates;
using FluentValidation;
using FluentValidation.Results;
using FluentValidationLibrary.Classes;
using FluentValidationLibrary.Extensions;
using FluentValidationLibrary.Models;


namespace FluentValidationLibrary.Validators
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {

            RuleFor(customer => customer.FirstName)
                .NotEmpty()
                .MinimumLength(5)
                .MaximumLength(10)
                .WithName("First name");

            RuleFor(customer => customer.LastName)
                .NotEmpty()
                .MinimumLength(5)
                .MaximumLength(30);

            RuleFor(customer => customer.NotesList)
                .ListMustContainFewerThan(5);

            RuleFor(customer => customer.CreditCardNumber)
                .CreditCard();

            RuleFor(customer => customer.Pin)
                .Length(4)
                .Must(pin => pin.HaveValidPin());

            RuleFor(customer => customer.Country)
                .NotNull();

            RuleFor(customer => customer.Country.CountryName).NotEqual("Select");
            

            When(customer => customer != null, () => RuleFor(x => x.Country).NotNull());

            Transform(
                from: customer => customer.SocialSecurity,
                to: value => value.IsSocialSecurityNumberValid()).Must(value => value)
                .WithMessage("SSN is required");

            Transform(
                    from: customer => customer.PostalCode,
                    to: value => value.HasValidPostcode()).Must(value => value)
                .WithMessage("Required a valid postal code");


        }

        protected override bool PreValidate(ValidationContext<Customer> context, ValidationResult result)
        {
            if (context.InstanceToValidate is null)
            {
                result.Errors.Add(new ValidationFailure("", $"Dude, must have a none null instance of {nameof(Customer)}"));
                return false;
            }
            return true;
        }
    }
}
