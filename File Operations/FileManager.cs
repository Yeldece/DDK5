using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
namespace FileOperations
{
    public class fileManager
    {
        List<City> Cities = new();
        public fileManager(string path)
        {
            string[] content = File.ReadAllLines(path, System.Text.Encoding.UTF8);
            foreach (var line in content)
            {
                string[] ParsedLine = line.Split(", ");
                Cities.Add(new City(ParsedLine[0], new Country(ParsedLine[1])));
            }
        }
        public void CountryHasTopCity()
        {
            var x = Cities.GroupBy(x => x.CountryBelongsTo.Name).OrderByDescending(x=>x.Count());
        }
    }
}