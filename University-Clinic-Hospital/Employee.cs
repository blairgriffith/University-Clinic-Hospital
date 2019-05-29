using System;
using System.Collections.Generic;
using System.Text;

namespace University_Clinic_Hospital
{
    public class Employee
    {
        public string Name { get;set;}
        public int EmployeeNumber { get; set; }
        public string Salary { get; set; }
        public bool SalaryPaid { get; set; }

        public Employee (string name, int employeeNumber)
        {
            Name = name;
            EmployeeNumber = employeeNumber;
            SalaryPaid = false;
        }
    }
}
