using System;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            string csvFilePath = @"Final.txt";

            var reader = new CsvReader(csvFilePath);

            var countries = reader.ReadAllCountries();

            foreach (var country in countries)  
            {
                System.Console.WriteLine($"{country.Name} : {country.Code}");
            }

            
        }
    }
}
