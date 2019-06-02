using System;
using System.Collections.Generic;
using System.Text;

namespace University_Clinic_Hospital
{
    public class Receptionist : Employee
    {
        public bool OnPhone { get; set; }
        public Receptionist(string name, int employeeNumber) : base()
        {
            Name = name;
            Type = "Receptionist";
            EmployeeNumber = employeeNumber;
            Salary = "$45,000";
            OnPhone = false;
        }
        public void EndPhoneCall(Receptionist receptionist)
        {
            if (receptionist.OnPhone == false)
            {
                receptionist.OnPhone = true;
                Console.WriteLine($"Receptionist has ended phone call");
            }

        }
    }
}