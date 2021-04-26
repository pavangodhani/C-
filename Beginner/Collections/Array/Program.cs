using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // string filePath = @"E:\KLing\C#\Collections\Array\Final.txt";
            string filePath = @"Final.txt";

            var reader = new CsvReader(filePath);

            Country[] countries = reader.ReadFirstnNCountries(5);

            foreach (var country in countries)
            {
                System.Console.WriteLine($"{country.Population} : {country.Name}");
            }
        }
    }
}
