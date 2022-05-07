using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FluentValidationLibrary.Validators;


// ReSharper disable once CheckNamespace - do not change
namespace FluentValidationLibrary
{
    public partial class MainTest
    {
        private CustomerValidator CustomerValidator;
        /// <summary>
        /// Perform initialization before test runs using assertion on current test name.
        /// </summary>
        [TestInitialize]
        public void Initialization()
        {
            CustomerValidator = new CustomerValidator();
        }
        /// <summary>
        /// Perform any initialize for the class
        /// </summary>
        /// <param name="testContext"></param>
        [ClassInitialize()]
        public static void ClassInitialize(TestContext testContext)
        {
            TestResults = new List<TestContext>();
        }
    }
}
