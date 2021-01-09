using System;
using System.Collections.Generic;
using System.Text;
using CareerPro.Model;

namespace CareerPro.Service.Repository
{
    public interface IJobCategoryRepository
    {
        public IEnumerable<JobCategory> GetJobCategories();
    }
}
