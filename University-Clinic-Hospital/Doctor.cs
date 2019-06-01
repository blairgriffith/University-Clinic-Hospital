using System;
using System.Collections.Generic;
using System.Text;

namespace University_Clinic_Hospital
{
    class Doctor : Employee
    {
        public string Specialty { get; set; }

        public Doctor(string name, int employeeNumber, string specialty) : base()
        {
            Name = name;
            EmployeeNumber = employeeNumber;
            Salary = "$90,000";
            Specialty = specialty;
        }
        
    }
}
