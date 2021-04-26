using System.Collections.Generic;
using System.IO;

namespace LINQ
{
    class CsvReader
    {
        private string csvFilePath;

        public CsvReader(string csvFilePath)
        {
            this.csvFilePath = csvFilePath;
        }

        public List<Country> ReadAllCountries()
        {
            var countries = new List<Country>();

            using (var sr = new StreamReader(csvFilePath))
            {
                sr.ReadLine();

                string csvLine;
                while ((csvLine = sr.ReadLine()) != null)
                {
                    countries.Add(ReadCountryFromCsvLine(csvLine));
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