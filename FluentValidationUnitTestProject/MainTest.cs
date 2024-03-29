using System.Linq;
using System.Threading.Tasks;
using FluentValidation.Results;
using FluentValidationLibrary.Base;
using FluentValidationLibrary.Extensions;
using FluentValidationLibrary.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using NFluent;

namespace FluentValidationLibrary
{
    [TestClass]
    public partial class MainTest : TestBase
    {
        [TestMethod]
        [TestTraits(Trait.FluentValidation)]
        public async Task ValidCustomerTest()
        {
            // arrange
            Customer thisCustomer = MockOperations.Customers.FirstOrDefault();

            // act
            ValidationResult result = await CustomerValidator.ValidateAsync(thisCustomer);

            // assert
            Check.That(result.IsValid).IsTrue();

        }

        [TestMethod]
        [TestTraits(Trait.FluentValidation)]
        public async Task InValidToManyNotesAndInvalidCreditCardNumberCustomerTest()
        {
            // arrange
            Customer thisCustomer = MockOperations.Customers.FirstOrDefault();
            thisCustomer!.CreditCardNumber = "111";

            int count = 5;
            
            string[] expected =
            {
                $"Notes List must contain fewer than {count} items.",
                "'Credit Card Number' is not a valid credit card number."
            };

            thisCustomer.NotesList.AddRange(new []{"2","3","4","5", "6"});
            
            // act
            ValidationResult result = await CustomerValidator.ValidateAsync(thisCustomer);
            var errors = result.Errors.Select(x => x.ErrorMessage).ToArray();

            // assert
            Check.That(errors).ContainsExactly(expected);
        }

        [TestMethod]
        [TestTraits(Trait.FluentValidation)]
        public async Task InvalidPinCustomerTest()
        {
            // arrange
            Customer thisCustomer = MockOperations.Customers.FirstOrDefault(cust => cust.Id == 2);
            
            // act
            ValidationResult result = await CustomerValidator.ValidateAsync(thisCustomer);
            
            // assert
            Check.That(result.IsValid).IsFalse();
        }

        /// <summary>
        /// Test PreValidate override for custom message when a <see cref="Customer"/> is null
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.FluentValidation)]
        public async Task NullCustomer()
        {
            // arrange
            Customer thisCustomer = null;
            
            // act
            // ReSharper disable once ExpressionIsAlwaysNull
            ValidationResult result = await CustomerValidator.ValidateAsync(thisCustomer);

            // assert
            result.ShowErrorMessage();
            Check.That(result.IsValid).IsFalse();
        }

        [TestMethod]
        [TestTraits(Trait.FluentValidation)]
        public async Task NullCountry()
        {
            // arrange
            Customer thisCustomer = MockOperations.Customers.FirstOrDefault();
            thisCustomer!.Country = null;


            // avt
            ValidationResult result = await CustomerValidator.ValidateAsync(thisCustomer);


            // assert
            Check.That(result.Errors.FirstOrDefault()!.ErrorMessage)
                .Equals("Dude, Country can not be null");
   
        }
    }
}
