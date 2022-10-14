using CodeFirstApproach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApproach.Repository
{
    public interface IEmployeeRepository
    {
        public List<EmployeeModels> GetEmployees();
    }
}
