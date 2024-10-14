using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class Employee
    {
        public string FullName { get; set; }
        public decimal Pay { get; set; }
        public DateTime DateOfEmployment { get; set; }

        public Employee(string fullName, decimal pay, DateTime dateTime)
        {
            FullName = fullName;
            Pay = pay;
            DateOfEmployment = dateTime;
        }
    }
}
