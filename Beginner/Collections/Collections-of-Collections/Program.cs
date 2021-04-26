using System;
using System.Linq;

namespace CollectionsOfCollections
{
    class Program
    {
        static void Main(string[] args)
        {

            int count = 0;
            string csvFilePath = @"Final.txt";

            var reader = new CsvReader(csvFilePath);

            var countries = reader.ReadAllCountries();

            var lilliput = new Country("Lilliput", "LIL", "someWhere", 300000000);

            // int lilliputIndex = countries.FindIndex(x => x.Population < 300000000); //lambda expression
            // countries.Insert(lilliputIndex, lilliput);
            // // countries.RemoveAt(lilliputIndex); //For remove iteam from specific index from list... 

            countries[lilliput.Region].Add(lilliput);

            foreach(string region in countries.Keys)
            {
                System.Console.WriteLine(region);
            }

            System.Console.WriteLine("\nWhich of the above regions do you want?");
            string chosenRegion = Console.ReadLine();
            
            System.Console.WriteLine("\n----------------");

            if(countries.ContainsKey(chosenRegion))
            {
                foreach (var country in countries[chosenRegion])
                {
                    System.Console.WriteLine($"{country.Name}");
                }
            }
            else
            {
                System.Console.WriteLine("This is not a valid region");
            }


            System.Console.WriteLine($"\n\n{count} : Countries...\n");
        }
    }
}
