using System;
using System.Collections.Generic;
using System.Text;

namespace University_Clinic_Hospital
{
    public class Receptionist : Employee
    {
        public Receptionist(string name, int employeeNumber) : base()
        {
            Name = name;
            Type = "Receptionist";
            EmployeeNumber = employeeNumber;
            Salary = "$45,000";
            Working = false;
        }
        public override void ChangeWorking(Employee receptionist)
        {
            if (receptionist.Working == false)
            {
                receptionist.Working = true;
                Console.WriteLine($"Receptionist has ended phone call");
            }
            else if (receptionist.Working == true)
            {
                receptionist.Working = false;
                Console.WriteLine($"Receptionist is now on the phone");
            }

        }
    }
}