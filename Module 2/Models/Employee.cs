using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Module_2.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int EmployeeNumber { get; set; }
        public int PositionId { get; set; }
        public decimal Salary { get; set; }
    }
}