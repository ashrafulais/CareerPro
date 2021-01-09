using CareerPro.Model;
using System.Collections.Generic;
using System.Text;

namespace CareerPro.Service.Repository
{
    public interface IAppUserRepo
    {
        public IEnumerable<AppUser> GetAppUsers();
        public AppUser GetAppUser(string userid);
    }
}
