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

            SocialSecurityNumberTextBox.ToggleShow(false);

            _customerBindingSource.DataSource = Operations.Customers;

            FirstNameTextBox.DataBindings.Add("Text", _customerBindingSource, nameof(Customer.FirstName));
            LastNameTextBox.DataBindings.Add("Text", _customerBindingSource, nameof(Customer.LastName));
            PinTextBox.DataBindings.Add("Text", _customerBindingSource, nameof(Customer.Pin));
            SocialSecurityNumberTextBox.DataBindings.Add("Text", _customerBindingSource, nameof(Customer.SocialSecurity));
            PostalCodeTextBox.DataBindings.Add("Text", _customerBindingSource, nameof(Customer.PostalCode));
            CountryComboBox.DataBindings.Add(new Binding("SelectedValue", _customerBindingSource, nameof(Customer.Country), true, DataSourceUpdateMode.OnPropertyChanged));

        }

        private void ValidateButton_Click(object sender, EventArgs e)
        {

            Customer customer = (Customer)_customerBindingSource.Current;

            _customerValidator = new CustomerValidator();
            ValidationResult result = _customerValidator.Validate(customer);

            Dialogs.Information(result.PresentErrorMessage());

        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SocialSecurityNumberTextBox.ToggleShow(checkBox1.Checked);
        }
    }
}