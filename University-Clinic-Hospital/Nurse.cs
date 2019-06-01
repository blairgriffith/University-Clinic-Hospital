using System;
using System.Collections.Generic;
using System.Text;

namespace University_Clinic_Hospital
{
    public class Nurse : Employee
    {
        public int NumberOfPatients { get; set; }
        public Nurse(string name, int employeeNumber, int numberOfPatients) : base()
        {
            Name = name;
            EmployeeNumber = employeeNumber;
            Salary = "$50,000";
            NumberOfPatients = numberOfPatients;
        }
        
    }
}
