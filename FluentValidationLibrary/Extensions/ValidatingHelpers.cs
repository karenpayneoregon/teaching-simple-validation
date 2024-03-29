﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using FluentValidation.Results;
using FluentValidationLibrary.Models;

namespace FluentValidationLibrary.Extensions
{
    public static class ValidatingHelpers
    {
        /// <summary>
        /// Extreme validation for social security number
        /// </summary>
        /// <param name="ssn">value to validate</param>
        /// <returns></returns>
        /// <remarks>
        /// For simple validation see BaseDataValidatorLibrary.CommonRules.SocialSecurityAttribute
        /// </remarks>
        public static bool IsSocialSecurityNumberValid(this string ssn)
        {
            if (string.IsNullOrWhiteSpace(ssn))
            {
                return false;
            }

            if (ssn.Length == 9)
            {
                ssn = ssn.Insert(5, "-").Insert(3, "-");
            }

            return !string.IsNullOrWhiteSpace(ssn) && new Regex(
                    @"^(?!\b(\d)\1+-(\d)\1+-(\d)\1+\b)(?!123-45-6789|219-09-9999|078-05-1120)(?!666|000|9\d{2})\d{3}-(?!00)\d{2}-(?!0{4})\d{4}$")
                .IsMatch(ssn);
        }

        public static bool HasValidPostcode(this string postcode)
        {
            List<string> list = new() { "97301", "97223", "97209", "97146", "97374", "97734" };
            var result = list.FirstOrDefault(item => item == postcode);
            return result is not null;
        }

        /// <summary>
        /// Simple example to show how to do a validation 
        /// </summary>
        /// <param name="pin"></param>
        /// <returns></returns>
        public static bool HaveValidPin(this string pin)
        {
            List<string> list = new() { "1111", "1234", "5555"};
            var result = list.FirstOrDefault(item => item == pin);
            return result is null;
        }

        public static string ValidCountryName(this Country sender) => 
            sender is null ? 
                "Select" : 
                sender.CountryName;

        /// <summary>
        /// Quick way to show error text, for teaching only
        /// </summary>
        public static void ShowErrorMessage(this ValidationResult sender)
        {
            sender.Errors.ForEach(x => Debug.WriteLine(x.ErrorMessage));
        }

        /// <summary>
        /// Quick way to show error text, for teaching only
        /// </summary>
        public static string PresentErrorMessage(this ValidationResult sender)
        {
            StringBuilder builder = new ();
            
            sender.Errors.Select(validationFailure => validationFailure.ErrorMessage)
                .ToList()
                .ForEach(x => builder.AppendLine(x));

            return builder.Length == 0 ? 
                "Valid" : 
                builder.ToString();
            
        }

        public static bool IsNotWeekend(this DateTime senderDate)
        {
            DateTime date = Convert.ToDateTime(senderDate);
            return date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday;
        }
    }
}