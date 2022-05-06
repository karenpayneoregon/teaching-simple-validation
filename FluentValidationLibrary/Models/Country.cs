namespace FluentValidationLibrary.Models
{
    public class Country
    {
        public int CountryIdentifier { get; set; }
        public string CountryName { get; set; }
        public override string ToString() => CountryName;

    }
}
