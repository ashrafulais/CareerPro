using CareerPro.Model;
using System.Collections.Generic;

namespace CareerPro.Service.Services
{
    public interface IAppUserService
    {
        public IEnumerable<AppUser> GetAppUsersService();
        public AppUser GetAppUser(string userid);
    }
}
