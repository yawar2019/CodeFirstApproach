using CodeFirstApproach.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApproach.Controllers
{
    public class EmployeesController : Controller
    {
        public IEmployeeRepository _employeeRepository;
        public EmployeesController(IEmployeeRepository employeeRepository)//=EmployeeRepository1(Dapper)
        {
            _employeeRepository = employeeRepository;
        }
        public IActionResult Index()
        {
            return View(_employeeRepository.GetEmployees());
        }
    }
}
