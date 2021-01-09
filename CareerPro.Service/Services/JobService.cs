using CareerPro.Model;
using CareerPro.Model.ViewModels;
using CareerPro.Service.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CareerPro.Service.Services
{
    public class JobService : IJobService
    {
        private readonly IJobRepository jobRepository;
        private readonly IPersonRepo personRepo;
        private readonly ICompanyRepo companyRepo;
        public SearchJobViewModel searchJobViewModel = new SearchJobViewModel();

        public JobService(IJobRepository jobRepository,
            IPersonRepo personRepo,
            ICompanyRepo companyRepo)
        {
            this.jobRepository = jobRepository;
            this.personRepo = personRepo;
            this.companyRepo = companyRepo;
        }
        public JobViewModel ToJobViewModel(Job job)
        {
            JobViewModel model = new JobViewModel()
            {
                PublisherID = job.PostedByUser.Id,
                PublisherEmail = job.PostedByUser.Email,
                PublisherPhoto = job.PostedByUser.ProfilePicUrl,
                PublisherType = (job.PostedByUser.UserType == 0 ? "Person" : "Company"),
                PublisherName = (job.PostedByUser.UserType == 0 ?
                    personRepo.GetPerson(job.PostedByUser.Id).FullName :
                    companyRepo.GetCompany(job.PostedByUser.Id).Title),
                JobID = job.JobID,
                Title = job.Title,
                Description = job.Description,
                Address = job.Address,
                JobCategory = job.Category.CategoryName,
                DatePublished = job.DatePublished,
                Deadline = job.Deadline,
                Salary = job.Salary
            };
            return model;
        }
        public IEnumerable<JobViewModel> GetJobsListService()
        {
            List<Job> jobsList = jobRepository.GetJobsList()
                .Where(j => j.Deadline >= DateTime.UtcNow)
                .Skip((searchJobViewModel.PageNumber-1) * searchJobViewModel.PageSize)
                .Take(searchJobViewModel.PageSize)
                .ToList();

            List<JobViewModel> jobViewModels = new List<JobViewModel>();
            jobViewModels = jobsList.Select(job => ToJobViewModel(job)).ToList();
            
            //debugging helper for each object
            /*foreach(var job in jobsList)
            {
                JobViewModel model = new JobViewModel();

                model.PublisherID = job.PostedByUser.Id;
                model.PublisherEmail = job.PostedByUser.Email;
                model.PublisherPhoto = job.PostedByUser.ProfilePicUrl;
                model.PublisherType = (job.PostedByUser.UserType == 0 ? "Person" : "Company");
                model.PublisherName = (job.PostedByUser.UserType == 0 ?
            personRepo.GetPerson(job.PostedByUser.Id).FullName :
            companyRepo.GetCompany(job.PostedByUser.Id).Title);
                model.JobID = job.JobID;
                model.Title = job.Title;
                model.Description = job.Description;
                model.Address = job.Address;
                model.JobCategory = job.Category.CategoryName;
                model.DatePublished = job.DatePublished;
                model.Deadline = job.Deadline;
                model.Salary = job.Salary;
            }*/

            return jobViewModels;
        }

        public IEnumerable<JobViewModel> GetJobsListService(SearchJobViewModel model)
        {
            //return jobRepository.GetFilteredJobsList(model);

            List<JobViewModel> jobViewModels = jobRepository.GetFilteredJobsList(model)
                .Where(j => j.Deadline >= DateTime.UtcNow)
                .Skip((model.PageNumber - 1) * model.PageSize)
                .Take(model.PageSize)
                .Select(job => ToJobViewModel(job))
                .ToList();
            return jobViewModels;
        }

        public JobViewModel GetJobService(string jobid)
        {
            return ToJobViewModel(jobRepository.GetJob(jobid));
        }
    }
}
