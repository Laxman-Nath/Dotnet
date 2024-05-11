using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreBasics.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; } // Primary key
        public string EmpFirstName { get; set; }
        public string EmpLastName {  get; set; }
        public long Salary { get; set; }
        
      

    }
}
