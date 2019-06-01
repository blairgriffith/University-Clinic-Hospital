using System;
using System.Collections.Generic;
using System.Text;

namespace University_Clinic_Hospital
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int EmployeeNumber { get; set; }
        public string Salary { get; set; }
        public bool SalaryPaid { get; set; }

        public Employee ()
        {
            SalaryPaid = false;
        }

    }
}
