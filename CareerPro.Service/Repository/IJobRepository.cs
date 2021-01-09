using CareerPro.Model;
using CareerPro.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CareerPro.Service.Repository
{
    public interface IJobRepository
    {
        public Job GetJob(string jobid);
        public IEnumerable<Job> GetJobsList();
        public IEnumerable<Job> GetFilteredJobsList(SearchJobViewModel model);
    }
}
