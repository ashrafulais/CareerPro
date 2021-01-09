using CareerPro.Model;
using CareerPro.Model.ViewModels;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CareerPro.Service.Repository
{
    public class JobRepository : IJobRepository
    {
        private readonly CareerDbContext context;
        private IEnumerable<Job> JobsList = new List<Job>();
        public JobRepository(CareerDbContext context)
        {
            JobsList = new List<Job>()
            {
                new Job()
                {
                    PostedByUser = new AppUserRepo().GetAppUser("userid1"),
                    JobID="job1",
                    Title="Software Engineer",
                    Description="We are looking for an experienced Software Engineer who has efficient Codign skill and experienced in ASP.NET Core Tech.",
                    Category = new JobCategoryRepository().GetJobCategories()
                        .FirstOrDefault(j => j.CategoryID=="programmer"),
                    DatePublished = DateTime.UtcNow,
                    Deadline = DateAndTime.DateAdd(DateInterval.Month, 5, DateTime.UtcNow),
                    Address = "Dhaka, Bangladesh",
                    Salary = 60000M
                },
                new Job()
                {
                    PostedByUser = new AppUserRepo().GetAppUser("userid4"),
                    JobID="job2",
                    Title="Digital Marketing Specialist",
                    Description="We are looking for an experienced Digital Marketing Specialist who has efficient skill and experienced in Digital Marketing.",
                    Category = new JobCategoryRepository().GetJobCategories()
                        .FirstOrDefault(j => j.CategoryID=="IT"),
                    DatePublished = DateTime.UtcNow,
                    Deadline = DateAndTime.DateAdd(DateInterval.Month, 5, DateTime.UtcNow),
                    Address = "Khulna, Bangladesh",
                    Salary = 50000M
                },
                new Job()
                {
                    PostedByUser = new AppUserRepo().GetAppUser("userid2"),
                    JobID="job3",
                    Title="Data Engineer",
                    Description="We are looking for an experienced Data Engineer who has efficient Codign skill and experienced in Big Data.",
                    Category = new JobCategoryRepository().GetJobCategories()
                        .FirstOrDefault(j => j.CategoryID=="programmer"),
                    DatePublished = DateTime.UtcNow,
                    Deadline = DateAndTime.DateAdd(DateInterval.Month, 5, DateTime.UtcNow),
                    Address = "Dhaka, Bangladesh",
                    Salary = 80000M
                },
                new Job()
                {
                    PostedByUser = new AppUserRepo().GetAppUser("userid5"),
                    JobID="job4",
                    Title="Digital Marketing Intern",
                    Description="We are looking for an experienced Digital Marketing Intern who has skill and experienced in Digital Marketing.",
                    Category = new JobCategoryRepository().GetJobCategories()
                        .FirstOrDefault(j => j.CategoryID=="IT"),
                    DatePublished = DateTime.UtcNow,
                    Deadline = DateAndTime.DateAdd(DateInterval.Month, 5, DateTime.UtcNow),
                    Address = "Khulna, Bangladesh",
                    Salary = 10000M
                },
                new Job()
                {
                    PostedByUser = new AppUserRepo().GetAppUser("userid2"),
                    JobID="job5",
                    Title="Support Engineer",
                    Description="We are looking for an experienced Support Engineer who has efficient Codign skill and experienced in ASP.NET Core Tech.",
                    Category = new JobCategoryRepository().GetJobCategories()
                        .FirstOrDefault(j => j.CategoryID=="programmer"),
                    DatePublished = DateTime.UtcNow,
                    Deadline = DateAndTime.DateAdd(DateInterval.Month, 5, DateTime.UtcNow),
                    Address = "Dhaka, Bangladesh",
                    Salary = 60000M
                },
                new Job()
                {
                    PostedByUser = new AppUserRepo().GetAppUser("userid5"),
                    JobID="job6",
                    Title="Mechanical Engineer",
                    Description="We are looking for an experienced Mechanical Engineer who has efficient skill and experienced in the field.",
                    Category = new JobCategoryRepository().GetJobCategories()
                        .FirstOrDefault(j => j.CategoryID=="engg"),
                    DatePublished = DateTime.UtcNow,
                    Deadline = DateAndTime.DateAdd(DateInterval.Month, 5, DateTime.UtcNow),
                    Address = "Khulna, Bangladesh",
                    Salary = 50000M
                },
                new Job()
                {
                    PostedByUser = new AppUserRepo().GetAppUser("userid1"),
                    JobID="job7",
                    Title="Technical Engineer",
                    Description="We are looking for an experienced Technical Engineer who has efficient Codign skill and experienced in the Tech.",
                    Category = new JobCategoryRepository().GetJobCategories()
                        .FirstOrDefault(j => j.CategoryID=="engg"),
                    DatePublished = DateTime.UtcNow,
                    Deadline = DateAndTime.DateAdd(DateInterval.Month, 5, DateTime.UtcNow),
                    Address = "Dhaka, Bangladesh",
                    Salary = 60000M
                },
                new Job()
                {
                    PostedByUser = new AppUserRepo().GetAppUser("userid2"),
                    JobID="job8",
                    Title="Data analyst",
                    Description="We are looking for an experienced Data analyst who has efficient skill and experienced in the field.",
                    Category = new JobCategoryRepository().GetJobCategories()
                        .FirstOrDefault(j => j.CategoryID=="analyst"),
                    DatePublished = DateTime.UtcNow,
                    Deadline = DateAndTime.DateAdd(DateInterval.Month, 5, DateTime.UtcNow),
                    Address = "Khulna, Bangladesh",
                    Salary = 50000M
                },
                new Job()
                {
                    PostedByUser = new AppUserRepo().GetAppUser("userid4"),
                    JobID="job9",
                    Title="Support Engineer",
                    Description="We are looking for an experienced Software Engineer who has efficient Codign skill and experienced in ASP.NET Core Tech.",
                    Category = new JobCategoryRepository().GetJobCategories()
                        .FirstOrDefault(j => j.CategoryID=="IT"),
                    DatePublished = DateTime.UtcNow,
                    Deadline = DateAndTime.DateAdd(DateInterval.Month, 5, DateTime.UtcNow),
                    Address = "Dhaka, Bangladesh",
                    Salary = 60000M
                },
                new Job()
                {
                    PostedByUser = new AppUserRepo().GetAppUser("userid1"),
                    JobID="job10",
                    Title="Product Marketing Specialist",
                    Description="We are looking for an experienced Marketing Specialist who has efficient skill and experienced in Marketing.",
                    Category = new JobCategoryRepository().GetJobCategories()
                        .FirstOrDefault(j => j.CategoryID=="IT"),
                    DatePublished = DateTime.UtcNow,
                    Deadline = DateAndTime.DateAdd(DateInterval.Month, 5, DateTime.UtcNow),
                    Address = "Khulna, Bangladesh",
                    Salary = 50000M
                }
            };
            this.context = context;
        }

        public IEnumerable<Job> GetFilteredJobsList(SearchJobViewModel model)
        {
            return JobsList.Where(job => 
                job.Title.Contains(model.JobTitle) &&
                job.Category.CategoryID.Contains(model.SelectedJobCategory.CategoryID));
        }

        public Job GetJob(string jobid)
        {
            return JobsList.FirstOrDefault(j => j.JobID == jobid);
        }

        public IEnumerable<Job> GetJobsList()
        {
            return JobsList;
        }
    }
}
