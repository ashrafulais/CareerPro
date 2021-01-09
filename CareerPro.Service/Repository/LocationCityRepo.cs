using CareerPro.Model;
using System.Collections.Generic;

namespace CareerPro.Service.Repository
{
    public class LocationCityRepo : ILocationCityRepo
    {
        private IEnumerable<LocationCity> LocationCities = new List<LocationCity>();
        public LocationCityRepo()
        {
            LocationCities = new List<LocationCity>()
            {
                new LocationCity() 
                { 
                    CityID="c1", 
                    CityName="Dhaka", 
                    CityState = new LocationState() {StateID="s1"}
                },
                new LocationCity()
                {
                    CityID="c2",
                    CityName="Savar",
                    CityState = new LocationState() {StateID="s1"}
                },
                new LocationCity()
                {
                    CityID="c3",
                    CityName="Satkhira",
                    CityState = new LocationState() {StateID="s2"}
                }
            };
        }
        public IEnumerable<LocationCity> GetLocationCities()
        {
            return LocationCities;
        }
    }

}
