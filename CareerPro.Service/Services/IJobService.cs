using CareerPro.Model;
using CareerPro.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CareerPro.Service.Services
{
    public interface IJobService
    {
        public JobViewModel GetJobService(string jobid);
        public IEnumerable<JobViewModel> GetJobsListService();
        public IEnumerable<JobViewModel> GetJobsListService(SearchJobViewModel model);
    }
}
