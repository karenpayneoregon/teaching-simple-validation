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

namespace SampleFormApp1
{
    public partial class Form1 : Form
    {
        private CustomerValidator _customerValidator = new ();
        public Form1()
        {
            InitializeComponent();

            Shown += OnShown;
            
        }



        private void OnShown(object sender, EventArgs e)
        {
            List<Country> countries = Operations.Countries();
            CountryComboBox.DataSource =  countries;
            SocialSecurityNumberTextBox.ToggleShow(false);
        }

        private void ValidateButton_Click(object sender, EventArgs e)
        {
            Customer customer = new()
            {
                NotesList = new List<string>() //, Country = new Country(), PostalCode = "9223"// CountryComboBox.Country()
            };

            //customer.Country = new Country() {CountryIdentifier = -1, CountryName = "Select"};
            customer.Country = null;
            customer.FirstName = FirstNameTextBox.Text;
            customer.LastName = LastNameTextBox.Text;
            customer.Country = CountryComboBox.Country();
            customer.Pin = PinTextBox.Text;
            customer.SocialSecurity = SocialSecurityNumberTextBox.Text;
            customer.PostalCode = PostalCode.Text;

            _customerValidator = new CustomerValidator();
            ValidationResult result = _customerValidator.Validate(customer);

            result.ShowErrorMessage();


        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SocialSecurityNumberTextBox.ToggleShow(checkBox1.Checked);
        }
    }
}