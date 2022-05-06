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
            CountryComboBox.DataSource = Operations.Countries();
        }

        private void ValidateButton_Click(object sender, EventArgs e)
        {
            Customer customer = new()
            {
                NotesList = new List<string>(), Country = new Country() // CountryComboBox.Country()
            };


            _customerValidator = new CustomerValidator();
            ValidationResult result = _customerValidator.Validate(customer);

            MessageBox.Show(result.PresentErrorMessage());
        }
    }
}