using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApproach.Models
{
    public class EmployeeModels
    {
        [Key]
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int EmpSalary { get; set; }
    }

    public class RegistrationForTagHelper
    {
        [Key]
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpNames { get; set; }
        public int EmpSalary { get; set; }
        public string Address { get; set; }
        public bool Ischecked { get; set; }

    }
}
