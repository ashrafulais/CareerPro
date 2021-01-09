using CareerPro.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CareerPro.Service.Repository
{
    public interface ILocationStateRepo
    {
        public IEnumerable<LocationState> GetLocationStates();
    }
}
