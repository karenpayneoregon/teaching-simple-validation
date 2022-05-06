using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using FluentValidationLibrary.Models;

namespace SampleFormApp1.Classes
{
    public class Operations
    {
        public static List<Country> Countries()
        {
            var list = JsonSerializer.Deserialize<List<Country>>(File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Countries.json")));

            list!.Insert(0, new Country() {CountryIdentifier = -1, CountryName = "Select"});
            
            return list;
        }

        public static List<string> CreditCardNumbersValid => new()
        {
            "371144371144376",
            "341134113411347",
            "370000000000002",
            "378282246310005",
            "6011016011016011",
            "6559906559906557",
            "6011000000000012",
            "6011111111111117",
            "5111005111051128",
            "5112345112345114",
            "5424000000000015",
            "5105105105105100",
            "4112344112344113",
            "4007000000027",
            "4111111111111111",
            "4110144110144115",
            "4114360123456785",
            "4061724061724061",
            "5115915115915118",
            "5116601234567894",
            "36111111111111",
            "36110361103612",
            "36438936438936",
            "30569309025904",
        };

    }
}
