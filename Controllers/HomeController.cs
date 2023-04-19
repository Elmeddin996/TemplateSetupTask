using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TemplateSetupTask.ViewModels;
using TemplateSetupTask.DataAccess;

namespace TemplateSetupTask.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            ViewModel vm = new ViewModel
            {
                Features=Data.Features,
                Services=Data.Services
            
            };

            return View(vm);
        }
        public IActionResult About()
        {

            return View();
        }
        public IActionResult Contact()
        {

            return View();
        }


    }
}
