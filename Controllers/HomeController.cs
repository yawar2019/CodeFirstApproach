using CodeFirstApproach.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApproach.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

       public ActionResult TagHelperExample()
        {
            List<EmployeeModels> lisEmp = new List<EmployeeModels>();
            
            EmployeeModels employee = new EmployeeModels();
            employee.EmpId = 1;
            employee.EmpName = "Rakesh";

            EmployeeModels employee1 = new EmployeeModels();
            employee1.EmpId = 2;
            employee1.EmpName = "Mahesh";

            lisEmp.Add(employee);
            lisEmp.Add(employee1);
           

            ViewBag.employees =new SelectList(lisEmp,"EmpId","EmpName");

            return View();
        }

        [HttpPost]
        public ActionResult TagHelperExample(int id)
        {
            var listEmployee = new List<EmployeeModels>();
            return View();
        
        }

        [HttpPost]
        public ActionResult TagHelperExample2(int id,string place)
        {
            return View();
        }

        [Route("Home/TagHelp3",Name = "TagHelperRoute")]
        public ActionResult TagHelperExample3()
        {
            return View();
        }

        public ActionResult ClickMethod(string name)
        {
            ViewData["name"] = name;
            return View();
        }
        [HttpPost]
        public ActionResult RegisterInput(RegistrationForTagHelper emp)
        {
            return View();
        }
    }
}
