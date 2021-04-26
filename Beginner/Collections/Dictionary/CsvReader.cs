using System.Collections.Generic;
using System.IO;

namespace Dictionary
{
    class CsvReader
    {
        private string csvFilePath;

        public CsvReader(string csvFilePath)
        {
            this.csvFilePath = csvFilePath;
        }

        public Dictionary<string, Country> ReadAllCountries()
        {
            var countries = new Dictionary<string, Country>();

            using (var sr = new StreamReader(csvFilePath))
            {
                sr.ReadLine();

                string csvLine;
                while ((csvLine = sr.ReadLine()) != null)
                {
                    var country = ReadCountryFromCsvLine(csvLine);
                    countries.Add(country.Code, country);
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