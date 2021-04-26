using System.Collections.Generic;
using System.IO;

namespace CollectionsOfCollections
{
    class CsvReader
    {
        private string csvFilePath;

        public CsvReader(string csvFilePath)
        {
            this.csvFilePath = csvFilePath;
        }

        public Dictionary<string, List<Country>> ReadAllCountries()
        {
            var countries = new Dictionary<string, List<Country>>();

            using (var sr = new StreamReader(csvFilePath))
            {
                sr.ReadLine();

                string csvLine;
                while ((csvLine = sr.ReadLine()) != null)
                {
                    var country = ReadCountryFromCsvLine(csvLine);

                    if(countries.ContainsKey(country.Region))
                    {
                        countries[country.Region].Add(country);
                    }
                    else
                    {
                        var countriesInRegion = new List<Country>();
                        countriesInRegion.Add(country);

                        countries.Add(country.Region, countriesInRegion);
                    }
                }
            }

            return countries;

        }

        public Country ReadCountryFromCsvLine(string csvLine)
        {
            string[] parts = csvLine.Split(',');

            string name = parts[0];
            string code = parts[1];
            string region = parts[2];
            int population = int.Parse(parts[3]);

            return new Country(name, code, region, population);
        }
    }
}