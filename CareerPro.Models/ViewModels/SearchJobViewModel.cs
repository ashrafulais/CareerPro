using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CareerPro.Model.ViewModels
{
    public class SearchJobViewModel : Paginate
    {
        public string JobTitle { get; set; }
        public JobCategory SelectedJobCategory { get; set; } = new JobCategory();
        public IEnumerable<JobCategory> JobCategories { get; set; } = new List<JobCategory>();
        public IEnumerable<JobViewModel> Jobs { get; set; } = new List<JobViewModel>();
        public int JobsCount { get; set; }
    }
}
