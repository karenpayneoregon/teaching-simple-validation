using System;
using System.IO;
using System.Text.Json;

namespace FluentValidationLibrary.Models
{
    public class CustomerSettings
    {
        public FirstNameSettings FirstNameSettings { get; set; }
        public LastNameSettings LastNameSettings { get; set; }
    }

    public class SettingsOperations
    {
        private static readonly string _settingsFileName =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CustomerSettings.json");
        public static CustomerSettings ReadCustomerSettings() =>
            JsonSerializer.Deserialize<CustomerSettings>(File.ReadAllText(_settingsFileName));

    }

    public class FirstNameSettings   
    {
        public int MinimumLength { get; set; }
        public int MaximumLength { get; set; }
        public string WithName { get; set; }
    }
    public class LastNameSettings
    {
        public int MinimumLength { get; set; }
        public int MaximumLength { get; set; }
        public string WithName { get; set; }
    }
}
