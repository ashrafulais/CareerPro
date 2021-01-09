using CareerPro.Model.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace CareerPro.Model
{
    public static class ModelBuilderExtensions
    {
        public static void LoadSeedData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppUser>().HasData(
                new AppUser()
                {
                    Id = "userid1",
                    UserName = "johnsmith",
                    Email = "johnsmith@gmail.com",
                    DateAdded = DateTime.UtcNow,
                    PhoneNumber = "0123456789",
                    Address = "Mirpur-2, Dhaka",
                    ProfilePicUrl = "img/featured-listing-2.jpg",
                    ActiveUser = true,
                    UserType = UserTypeEnum.Person
                },
                new AppUser()
                {
                    Id = "userid2",
                    UserName = "doesup",
                    Email = "doesup@gmail.com",
                    DateAdded = DateTime.UtcNow,
                    PhoneNumber = "9123456789",
                    Address = "Banani, Dhaka",
                    ProfilePicUrl = "img/featured-listing-4.jpg",
                    ActiveUser = true,
                    UserType = UserTypeEnum.Person
                },
                new AppUser()
                {
                    Id = "userid4",
                    UserName = "abccorp",
                    Email = "abccorp@gmail.com",
                    DateAdded = DateTime.UtcNow,
                    PhoneNumber = "79746565421",
                    Address = "Headquarter: Kualalampur, Malaysia, Regional office: Dhaka, Bangladesh",
                    ProfilePicUrl = "img/featured-listing-1.jpg",
                    ActiveUser = true,
                    UserType = UserTypeEnum.Company
                },
                new AppUser()
                {
                    Id = "userid5",
                    UserName = "smartsoftware",
                    Email = "smartsoftware@gmail.com",
                    DateAdded = DateTime.UtcNow,
                    PhoneNumber = "6546541166",
                    Address = "Dhaka, Bangladesh",
                    ProfilePicUrl = "img/featured-listing-5.jpg",
                    ActiveUser = true,
                    UserType = UserTypeEnum.Company
                }
            );

            modelBuilder.Entity<JobCategory>().HasData(
                new JobCategory() { CategoryID = "IT", CategoryName = "IT" },
                new JobCategory() { CategoryID = "programmer", CategoryName = "Computer Programming" },
                new JobCategory() { CategoryID = "engg", CategoryName = "Engineering" },
                new JobCategory() { CategoryID = "analyst", CategoryName = "Data Analysis" }
            );

            modelBuilder.Entity<Job>().HasData(
                new Job()
                {
                    PostedByID = "userid1",
                    JobID = "job1",
                    Title = "Software Engineer",
                    Description = "We are looking for an experienced Software Engineer who has efficient Codign skill and experienced in ASP.NET Core Tech.",
                    CategoryID = "programmer",
                    DatePublished = DateTime.UtcNow,
                    Deadline = DateAndTime.DateAdd(DateInterval.Month, 5, DateTime.UtcNow),
                    Address = "Dhaka, Bangladesh",
                    Salary = 60000M
                }
                ,
                new Job()
                {
                    PostedByID = "userid4" ,
                    JobID = "job2",
                    Title = "Digital Marketing Specialist",
                    Description = "We are looking for an experienced Digital Marketing Specialist who has efficient skill and experienced in Digital Marketing.",
                    CategoryID = "IT",
                    DatePublished = DateTime.UtcNow,
                    Deadline = DateAndTime.DateAdd(DateInterval.Month, 5, DateTime.UtcNow),
                    Address = "Khulna, Bangladesh",
                    Salary = 50000M
                },
                new Job()
                {
                    PostedByID = "userid2" ,
                    JobID = "job3",
                    Title = "Data Engineer",
                    Description = "We are looking for an experienced Data Engineer who has efficient Codign skill and experienced in Big Data.",
                    CategoryID = "programmer" ,
                    DatePublished = DateTime.UtcNow,
                    Deadline = DateAndTime.DateAdd(DateInterval.Month, 5, DateTime.UtcNow),
                    Address = "Dhaka, Bangladesh",
                    Salary = 80000M
                },
                new Job()
                {
                    PostedByID = "userid5" ,
                    JobID = "job4",
                    Title = "Digital Marketing Intern",
                    Description = "We are looking for an experienced Digital Marketing Intern who has skill and experienced in Digital Marketing.",
                    CategoryID = "IT" ,
                    DatePublished = DateTime.UtcNow,
                    Deadline = DateAndTime.DateAdd(DateInterval.Month, 5, DateTime.UtcNow),
                    Address = "Khulna, Bangladesh",
                    Salary = 10000M
                },
                new Job()
                {
                    PostedByID = "userid2",
                    JobID = "job5",
                    Title = "Support Engineer",
                    Description = "We are looking for an experienced Support Engineer who has efficient Codign skill and experienced in ASP.NET Core Tech.",
                    CategoryID = "programmer" ,
                    DatePublished = DateTime.UtcNow,
                    Deadline = DateAndTime.DateAdd(DateInterval.Month, 5, DateTime.UtcNow),
                    Address = "Dhaka, Bangladesh",
                    Salary = 60000M
                },
                new Job()
                {
                    PostedByID = "userid5" ,
                    JobID = "job6",
                    Title = "Mechanical Engineer",
                    Description = "We are looking for an experienced Mechanical Engineer who has efficient skill and experienced in the field.",
                    CategoryID = "engg" ,
                    DatePublished = DateTime.UtcNow,
                    Deadline = DateAndTime.DateAdd(DateInterval.Month, 5, DateTime.UtcNow),
                    Address = "Khulna, Bangladesh",
                    Salary = 50000M
                },
                new Job()
                {
                    PostedByID = "userid1" ,
                    JobID = "job7",
                    Title = "Technical Engineer",
                    Description = "We are looking for an experienced Technical Engineer who has efficient Codign skill and experienced in the Tech.",
                    CategoryID = "engg",
                    DatePublished = DateTime.UtcNow,
                    Deadline = DateAndTime.DateAdd(DateInterval.Month, 5, DateTime.UtcNow),
                    Address = "Dhaka, Bangladesh",
                    Salary = 60000M
                },
                new Job()
                {
                    PostedByID = "userid2" ,
                    JobID = "job8",
                    Title = "Data analyst",
                    Description = "We are looking for an experienced Data analyst who has efficient skill and experienced in the field.",
                    CategoryID = "analyst" ,
                    DatePublished = DateTime.UtcNow,
                    Deadline = DateAndTime.DateAdd(DateInterval.Month, 5, DateTime.UtcNow),
                    Address = "Khulna, Bangladesh",
                    Salary = 50000M
                },
                new Job()
                {
                    PostedByID = "userid4" ,
                    JobID = "job9",
                    Title = "Support Engineer",
                    Description = "We are looking for an experienced Software Engineer who has efficient Codign skill and experienced in ASP.NET Core Tech.",
                    CategoryID = "IT",
                    DatePublished = DateTime.UtcNow,
                    Deadline = DateAndTime.DateAdd(DateInterval.Month, 5, DateTime.UtcNow),
                    Address = "Dhaka, Bangladesh",
                    Salary = 60000M
                },
                new Job()
                {
                    PostedByID = "userid1" ,
                    JobID = "job10",
                    Title = "Product Marketing Specialist",
                    Description = "We are looking for an experienced Marketing Specialist who has efficient skill and experienced in Marketing.",
                    CategoryID = "IT",
                    DatePublished = DateTime.UtcNow,
                    Deadline = DateAndTime.DateAdd(DateInterval.Month, 5, DateTime.UtcNow),
                    Address = "Khulna, Bangladesh",
                    Salary = 50000M
                }
            );
        }
    }
}
