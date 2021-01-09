using CareerPro.Model;
using CareerPro.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CareerPro.Service.Repository
{
    public class AppUserRepo : IAppUserRepo
    {
        private IEnumerable<AppUser> AppUsers = new List<AppUser>();
        public AppUserRepo()
        {
            AppUsers = new List<AppUser>()
            {
                new AppUser()
                {
                    Id="userid1",
                    UserName="johnsmith",
                    Email="johnsmith@gmail.com",
                    DateAdded=DateTime.UtcNow,
                    PhoneNumber="0123456789",
                    Address = "Mirpur-2, Dhaka",
                    ProfilePicUrl="img/featured-listing-2.jpg",
                    ActiveUser=true,
                    UserType=UserTypeEnum.Person
                },
                new AppUser()
                {
                    Id="userid2",
                    UserName="doesup",
                    Email="doesup@gmail.com",
                    DateAdded=DateTime.UtcNow,
                    PhoneNumber="9123456789",
                    Address = "Banani, Dhaka",
                    ProfilePicUrl="img/featured-listing-4.jpg",
                    ActiveUser=true,
                    UserType=UserTypeEnum.Person
                },
                new AppUser()
                {
                    Id="userid4",
                    UserName="abccorp",
                    Email="abccorp@gmail.com",
                    DateAdded=DateTime.UtcNow,
                    PhoneNumber="79746565421",
                    Address = "Headquarter: Kualalampur, Malaysia, Regional office: Dhaka, Bangladesh",
                    ProfilePicUrl="img/featured-listing-1.jpg",
                    ActiveUser=true,
                    UserType=UserTypeEnum.Company
                },
                new AppUser()
                {
                    Id="userid5",
                    UserName="smartsoftware",
                    Email="smartsoftware@gmail.com",
                    DateAdded=DateTime.UtcNow,
                    PhoneNumber="6546541166",
                    Address = "Dhaka, Bangladesh",
                    ProfilePicUrl="img/featured-listing-5.jpg",
                    ActiveUser=true,
                    UserType=UserTypeEnum.Company
                }
            };
        }

        public AppUser GetAppUser(string userid)
        {
            return AppUsers.FirstOrDefault(s => s.Id == userid);
        }

        public IEnumerable<AppUser> GetAppUsers()
        {
            return AppUsers;
        }
    }
}
