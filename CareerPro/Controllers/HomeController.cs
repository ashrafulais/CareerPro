using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CareerPro.Model.ViewModels;
using CareerPro.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CareerPro.Service.Services;

namespace CareerPro.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IJobCategoryService jobCategoryService;
        private readonly IJobService jobService;

        public HomeController(ILogger<HomeController> logger,
            IJobCategoryService jobCategoryService,
            IJobService jobService)
        {
            _logger = logger;
            this.jobCategoryService = jobCategoryService;
            this.jobService = jobService;
        }

        public IActionResult Index()
        {
            SearchJobViewModel searchJobViewModel = new SearchJobViewModel()
            {
                JobCategories = jobCategoryService.GetJobCategories()
            };

            return View(searchJobViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        /*public IActionResult GimmeJobs()
        {
            return Json(jobService.GetJobsListService());
        }

        [HttpPost]
        public IActionResult SearchJobsHandler(SearchJobViewModel model)
        {
            IEnumerable<JobViewModel> jobs = new List<JobViewModel>();
            jobs = jobService.GetJobsListService();

            return Json(jobs);
        }

        [HttpPost]
        public string SearchCandidateHandler()
        {
            return "Search candidate";
        }*/
    }
}
