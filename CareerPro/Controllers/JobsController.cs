using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CareerPro.Model;
using CareerPro.Model.ViewModels;
using CareerPro.Service.Services;
using Microsoft.AspNetCore.Mvc;

namespace CareerPro.Controllers
{
    public class JobsController : Controller
    {
        private readonly IJobCategoryService jobCategoryService;
        private readonly IJobService jobService;

        public JobsController(IJobCategoryService jobCategoryService,
            IJobService jobService)
        {
            this.jobCategoryService = jobCategoryService;
            this.jobService = jobService;
        }

        public IActionResult Index()
        {
            IEnumerable<JobViewModel> jobs = new List<JobViewModel>();
            jobs = jobService.GetJobsListService();

            SearchJobViewModel model = new SearchJobViewModel()
            {
                Jobs = jobs,
                JobCategories = jobCategoryService.GetJobCategories(),
                JobsCount = jobs.Count()
            };
            model.PaginateCount = (model.JobsCount / model.PageSize) + 1;
            return View(model);
        }
        public IActionResult GimmeJobs()
        {
            return Json(jobService.GetJobsListService());
        }

        [HttpPost]
        public IActionResult SearchJobs(SearchJobViewModel model)
        {
            model.JobTitle = model.JobTitle ?? "";
            model.SelectedJobCategory.CategoryID = model.SelectedJobCategory.CategoryID ?? "";

            ViewData["JobTitle"] = model.JobTitle;
            ViewData["JobCategory"] = model.SelectedJobCategory.CategoryID;

            IEnumerable<JobViewModel> jobs = new List<JobViewModel>();
            jobs = jobService.GetJobsListService(model);

            model = new SearchJobViewModel()
            {
                Jobs = jobs,
                JobCategories = jobCategoryService.GetJobCategories(),
                JobsCount = jobs.Count()
            };
            model.PaginateCount = (model.JobsCount / model.PageSize)+1;
            return View("Index", model);
        }
        
        public IActionResult JobSingle(string id)
        {
            if(id is null)
            {
                return RedirectToAction("Index");
            }
            return View(jobService.GetJobService(id));
        }

        public IActionResult Page(int pagenumber=0, string jobtitle="", string jobcategory="")
        {
            if (pagenumber > 0)
            {
                SearchJobViewModel model = new SearchJobViewModel()
                {
                    JobTitle = jobtitle,
                    PageNumber = pagenumber
                };
                model.SelectedJobCategory.CategoryID = jobcategory;
                model.Jobs = jobService.GetJobsListService(model);

                return View("index", model);
            }
            return RedirectToAction("Index");
        }
    }
}