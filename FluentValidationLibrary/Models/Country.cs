using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FluentValidationLibrary.Models
{
    public class Country : INotifyPropertyChanged
    {
        private string _countryName;
        private int _countryIdentifier;

        public int CountryIdentifier
        {
            get => _countryIdentifier;
            set
            {
                _countryIdentifier = value;
                OnPropertyChanged();
            }
        }

        public string CountryName
        {
            get => _countryName;
            set
            {
                _countryName = value;
                OnPropertyChanged();
            }
        }

        public override string ToString() => CountryName;

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
