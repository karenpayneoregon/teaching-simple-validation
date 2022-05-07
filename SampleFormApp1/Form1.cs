using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentValidation.Results;
using FluentValidationLibrary.Extensions;
using FluentValidationLibrary.Models;
using FluentValidationLibrary.Validators;
using HelpersLibrary.Classes;
using SampleFormApp1.Classes;
using SampleFormApp1.Extensions;
using WindowsFormsLibrary.Classes;

namespace SampleFormApp1
{
    public partial class Form1 : Form
    {
        private CustomerValidator _customerValidator = new ();
        private readonly BindingSource _customerBindingSource = new ();

        public Form1()
        {
            InitializeComponent();

            Shown += OnShown;
        }
        
        private void OnShown(object sender, EventArgs e)
        {

            CountryComboBox.DataSource = Operations.Countries();

            // so we start-off with a valid Customer
            CountryComboBox.SelectedIndex = 1;

            SocialSecurityNumberTextBox.ToggleShow(false);

            // This sets up for binding to the sole customer
            _customerBindingSource.DataSource = Operations.Customers;

            // data bind to customer properties
            FirstNameTextBox.DataBindings.Add("Text", _customerBindingSource, nameof(Customer.FirstName));
            LastNameTextBox.DataBindings.Add("Text", _customerBindingSource, nameof(Customer.LastName));
            BirthDatePicker.DataBindings.Add("Text", _customerBindingSource, nameof(Customer.BirthDate));
            PinTextBox.DataBindings.Add("Text", _customerBindingSource, nameof(Customer.Pin));
            SocialSecurityNumberTextBox.DataBindings.Add("Text", _customerBindingSource, nameof(Customer.SocialSecurity));
            PostalCodeTextBox.DataBindings.Add("Text", _customerBindingSource, nameof(Customer.PostalCode));
            CountryComboBox.DataBindings.Add(new Binding("SelectedValue", _customerBindingSource, nameof(Customer.Country), true, DataSourceUpdateMode.OnPropertyChanged));
            CreditCardTextBox.DataBindings.Add("Text", _customerBindingSource, nameof(Customer.CreditCardNumber));


        }


        /// <summary>
        /// Valid a <see cref="Customer"/> with several check boxes to allow
        /// the customer to be null which we have a rule in <see cref="CustomerValidator"/> pre-check
        /// and for a null <see cref="Customer.Country"/> there is a custom validator <see cref="CountryValidator"/>
        /// which checks for null along with a RuleFor on <see cref="Customer.Country"/> CountryName not equal to "Select"
        /// </summary>
        private void ValidateButton_Click(object sender, EventArgs e)
        {

            Customer customer = (Customer)_customerBindingSource.Current;

            if (MakeCustomerNullCheckBox.Checked)
            {
                customer = null;
            }

            if (MakeCountryNullCheckBox.Checked && customer != null)
            {
                customer.Country = null;
            }
            else
            {
                customer.Country = CountryComboBox.Country();
            }

            customer.NotesList = ValidNoteCountCheckBox.Checked ? 
                new List<string>() : 
                Enumerable.Range(1, 6).Select(x => x.ToString()).ToList();

            _customerValidator = new CustomerValidator();

            // perform validation
            ValidationResult result = _customerValidator.Validate(customer);

            /*
             * result.IsValid is the indicator if the customer is valid state or not.
             */
            Dialogs.Information(result.PresentErrorMessage());
            if (result.IsValid)
            {
                Operations.UpdateCustomer(customer);
            }

        }


        private void ShowHidePasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SocialSecurityNumberTextBox.ToggleShow(ShowHidePasswordCheckBox.Checked);
        }

    }
}