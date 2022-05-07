using FluentValidationLibrary.Models;

namespace FluentValidationLibrary.Classes
{
    /// <summary>
    /// Class for storing specific rules which has one method to create an initial file.
    /// </summary>
    public class Mocking
    {
        /// <summary>
        /// Only needed to create the initial settings file
        /// </summary>
        public static CustomerSettings CustomerSettings() => new()
        {
            FirstNameSettings = new FirstNameSettings() { MinimumLength = 5, MaximumLength = 10, WithName = "First name" },
            LastNameSettings = new LastNameSettings() { MinimumLength = 5, MaximumLength = 30, WithName = "Last name" }
        };

    }
}