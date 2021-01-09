using CareerPro.Model;
using System.Collections.Generic;

namespace CareerPro.Service.Repository
{
    public class LocationStateRepo : ILocationStateRepo
    {
        private IEnumerable<LocationState> LocationStates = new List<LocationState>();
        public LocationStateRepo()
        {
            LocationStates = new List<LocationState>()
            {
                new LocationState() 
                {
                    StateID="s1",
                    StateCode="DHK",
                    StateCountry = new LocationCountry() {CountryCode="bd"},
                    StateName = "Dhaka"
                },
                new LocationState()
                {
                    StateID="s2",
                    StateCode="CTG",
                    StateCountry = new LocationCountry() {CountryCode="bd"},
                    StateName = "Chittagong"
                },
                new LocationState()
                {
                    StateID="s3",
                    StateCode="KHU",
                    StateCountry = new LocationCountry() {CountryCode="bd"},
                    StateName = "Khulna"
                }
            };
        }
        public IEnumerable<LocationState> GetLocationStates()
        {
            return LocationStates;
        }
    }
}
