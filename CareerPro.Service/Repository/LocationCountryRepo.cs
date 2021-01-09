using CareerPro.Model;
using System.Collections.Generic;

namespace CareerPro.Service.Repository
{
    public class LocationCountryRepo : ILocationCountryRepo
    {
        private IList<LocationCountry> LocationCountries = new List<LocationCountry>();
        public LocationCountryRepo()
        {
            LocationCountries = new List<LocationCountry>()
            {
                new LocationCountry()
                {
                    CountryID = "bd",
                    CountryName = "Bangladesh",
                    CountryCode = "BD",
                    FlagPhotoUrl = "",
                    PhoneCode = "+880"
                }
            };
        }
        public IEnumerable<LocationCountry> GetLocationCountries()
        {
            return LocationCountries;
        }
    }
}
