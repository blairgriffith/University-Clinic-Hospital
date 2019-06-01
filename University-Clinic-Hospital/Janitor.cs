using System;
using System.Collections.Generic;
using System.Text;

namespace University_Clinic_Hospital
{
    public class Janitor : Employee
    {
        public bool Sweeping { get; set; }
        public Janitor(string name, int employeeNumber) : base()
        {
            Name = name;
            EmployeeNumber = employeeNumber;
            Salary = "$40,000";
            Sweeping = false;
        }

    }
}
