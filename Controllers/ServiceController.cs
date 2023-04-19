using Microsoft.AspNetCore.Mvc;
using TemplateSetupTask.DataAccess;
using TemplateSetupTask.DataAccess;
using TemplateSetupTask.Models;
using TemplateSetupTask.ViewModels;

namespace TemplateSetupTask.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            ViewModel vm = new ViewModel
            {
                Services = Data.Services
            };

            return View(vm);
        }
        public IActionResult Detail(int id)
        {
            Service srv = Data.Services.Find(x => x.Id == id);

            if (srv == null)
                return View("Error");


            return View(srv);
           
        }
    }
}
