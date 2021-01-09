using CareerPro.Model;
using CareerPro.Service.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#nullable enable
namespace CareerPro.Service.Services
{
    public class AppUserService : IAppUserService
    {
        private IAppUserRepo AppUserRepo { get; set; }
        public AppUserService(IAppUserRepo appUserRepo)
        {
            this.AppUserRepo = appUserRepo;
        }

        public IEnumerable<AppUser> GetAppUsersService()
        {
            return AppUserRepo.GetAppUsers()
                .Where(x => x.ActiveUser == true);
        }


        public AppUser GetAppUser(string userid)
        {
            AppUser? appUser = AppUserRepo.GetAppUser(userid) ?? new AppUser();

            if (appUser.Id is null) 
                throw new KeyNotFoundException($"User not found with id: {userid}");

            //otherwise this part will be excuted, return the app user
            return appUser;
        }
    }
}
