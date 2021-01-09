using CareerPro.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CareerPro.Service.Repository
{
    public class JobCategoryRepository : IJobCategoryRepository
    {
        private IEnumerable<JobCategory> JobCategories { get; set; }
        public JobCategoryRepository()
        {
            JobCategories = new List<JobCategory>()
            {
                new JobCategory() {CategoryID="IT", CategoryName="IT"},
                new JobCategory() {CategoryID="programmer", CategoryName="Computer Programming"},
                new JobCategory() {CategoryID="engg", CategoryName="Engineering"},
                new JobCategory() {CategoryID="analyst", CategoryName="Data Analysis"}
            };
        }
        public IEnumerable<JobCategory> GetJobCategories()
        {
            return JobCategories;
        }
    }
}
