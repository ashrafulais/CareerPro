using CareerPro.Model;
using CareerPro.Service.Repository;
using System.Collections.Generic;

namespace CareerPro.Service.Services
{
    public class JobCategoryService : IJobCategoryService
    {
        private readonly IJobCategoryRepository jobCategoryRepository;

        public JobCategoryService(IJobCategoryRepository jobCategoryRepository)
        {
            this.jobCategoryRepository = jobCategoryRepository;
        }
        public IEnumerable<JobCategory> GetJobCategories()
        {
            return jobCategoryRepository.GetJobCategories();
        }
    }
}
