using System;
using System.Collections.Generic;
using System.Text;
using CareerPro.Model.Enums;
using Microsoft.AspNetCore.Identity;

namespace CareerPro.Model
{
    public class AppUser : IdentityUser
    {
        public DateTime DateAdded { get; set; } = DateTime.UtcNow;
        public string ProfilePicUrl { get; set; }
        public string Address { get; set; }
        public UserTypeEnum UserType { get; set; } //0=Person,1=Company
        public bool ActiveUser { get; set; } = true;
    }
}