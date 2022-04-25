using System;
namespace FileOperations
{
    public class City : BaseModal
    {
        public Country CountryBelongsTo { get; set; }
        public City(string name, Country country)
        {
            Name = name;
            CountryBelongsTo = country;
        }
    }
}