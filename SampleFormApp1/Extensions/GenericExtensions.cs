using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FluentValidationLibrary.Models;

namespace SampleFormApp1.Extensions
{
    public static class GenericExtensions
    {
        /// <summary>
        /// Keeps code in form clean, generally not recommended to pass an entire control
        /// </summary>
        public static Country Country(this ComboBox sender) 
            => (Country)sender.SelectedItem;


        public static void ToggleShow(this TextBox sender, bool show = true)
        {
            sender.PasswordChar = show ?
                '\0' :
                '\u25CF';
        }
    }
}
