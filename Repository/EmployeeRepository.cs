using CodeFirstApproach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApproach.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public EmployeeContext _employeeContext;
        public EmployeeRepository(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }
        public List<EmployeeModels> GetEmployees()
        {
           return _employeeContext.employeeModels.ToList();
        }
    }
}
