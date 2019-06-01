using System;
using System.Collections.Generic;
using System.Text;

namespace University_Clinic_Hospital
{
    public class Receptionist : Employee
    {
        public bool OnPhone { get; set; }
        public Receptionist(string name, int employeeNumber, bool onPhone = false) : base()
        {
            Name = name;
            EmployeeNumber = employeeNumber;
            Salary = "$45,000";
            OnPhone = onPhone;
        }

    }
}
