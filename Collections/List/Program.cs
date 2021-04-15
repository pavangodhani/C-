using System;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {

            int count = 0;
            string csvFilePath = @"Final.txt";

            var reader = new CsvReader(csvFilePath);

            var countries = reader.ReadAllCountries();

            var lilliput = new Country("Lilliput", "LIL", "SomeWhere On Earth", 300000000);

            int lilliputIndex = countries.FindIndex(x => x.Population < 300000000); //lambda expression
            countries.Insert(lilliputIndex, lilliput);
            countries.RemoveAt(lilliputIndex);

            foreach (var country in countries)
            {
                System.Console.WriteLine($"{country.Name} : {country.Code}");
                count++;
            }

            System.Console.WriteLine($"\n\n{count} : Countries...\n");
        }
    }
}
