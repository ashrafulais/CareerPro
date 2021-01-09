using CareerPro.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CareerPro.Service.Services
{
    public interface IJobCategoryService
    {
        public IEnumerable<JobCategory> GetJobCategories();
    }
}
