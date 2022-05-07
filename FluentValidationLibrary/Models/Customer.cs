using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FluentValidationLibrary.Models
{
    public class Customer : INotifyPropertyChanged
    {
        private Country _country;
        private DateTime _birthDate;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public decimal CreditLimit { get; set; }
        public string CreditCardNumber { get; set; }
        public int Discount { get; set; }
        public bool HasDiscount { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public DateTime AppointmentDate { get; set; }

        public Country Country
        {
            get => _country;
            set
            {
                _country = value;
                OnPropertyChanged();
            }
        }

        public string Pin { get; set; }
        public string SocialSecurity { get; set; }

        public DateTime BirthDate
        {
            get => _birthDate;
            set
            {
                _birthDate = value;
                OnPropertyChanged();
            }
        }

        public List<string> NotesList { get; set; }
        public override string ToString() => $"{FirstName} {LastName}";


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
