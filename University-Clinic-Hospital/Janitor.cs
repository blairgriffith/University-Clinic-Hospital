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
            Type = "Janitor";
            EmployeeNumber = employeeNumber;
            Salary = "$40,000";
            Sweeping = false;
        }

        public void ChangeSweepingBehavior(Janitor selectedJanitor)
        {
            if (selectedJanitor.Sweeping == false)
            {
                selectedJanitor.Sweeping = true;
                Console.WriteLine($"{selectedJanitor.Name} is now sweeping.");
            }
            else if (selectedJanitor.Sweeping == true)
            {
                selectedJanitor.Sweeping = false;
                Console.WriteLine($"{selectedJanitor.Name} has stopped sweeping.");
            }
        }

    }
}
