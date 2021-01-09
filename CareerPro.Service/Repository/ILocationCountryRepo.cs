using CareerPro.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CareerPro.Service.Repository
{
    public interface ILocationCountryRepo
    {
        public IEnumerable<LocationCountry> GetLocationCountries();
    }
}
