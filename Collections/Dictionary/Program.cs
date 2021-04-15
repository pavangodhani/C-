using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string csvFilePath = @"Final.txt";

            var reader = new CsvReader(csvFilePath);

            var countries = reader.ReadAllCountries();

            System.Console.WriteLine("Which country code do you want to look up? ");
            string useInput = Console.ReadLine();

            bool gotCountry = countries.TryGetValue(useInput, out Country country);

            
            if(gotCountry)
            {
                System.Console.WriteLine($"{country.Name} : {country.Population}");
            }
            else
            {
                System.Console.WriteLine("Sorry, there is no country with this code");
            }


        }
    }
}
