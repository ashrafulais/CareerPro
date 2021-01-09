using CareerPro.Model;
using CareerPro.Service.Repository;
using System.Collections.Generic;

namespace CareerPro.Service.Services
{
    public class LocationStateService : ILocationStateService
    {
        private readonly ILocationStateRepo locationStateRepo;

        public LocationStateService(ILocationStateRepo locationStateRepo)
        {
            this.locationStateRepo = locationStateRepo;
        }
        public IEnumerable<LocationState> GetLocationStates()
        {
            return locationStateRepo.GetLocationStates();
        }
    }
}
