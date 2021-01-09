using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CareerPro.Service.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CareerPro.Controllers
{
    public class AppUserController : Controller
    {
        private IAppUserService AppUserService { get; }

        public AppUserController(IAppUserService appUserService)
        {
            this.AppUserService = appUserService;
        }

        public string Index()
        {
            return "Appuser controller running";
        }

        public IActionResult GetUserssList()
        {
            return Json(AppUserService.GetAppUsersService());
        }

        public IActionResult GetUser(string userid="userid1")
        {
            return Json(AppUserService.GetAppUser(userid));
        }
    }
}