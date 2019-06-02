using System;
using System.Collections.Generic;
using System.Text;

namespace University_Clinic_Hospital
{
    public class Janitor : Employee
    {
        public Janitor(string name, int employeeNumber) : base()
        {
            Name = name;
            Type = "Janitor     ";
            EmployeeNumber = employeeNumber;
            Salary = "$40,000";
            Working = false;
        }

        public override void ChangeWorking(Employee selectedJanitor)
        {
            if (selectedJanitor.Working == false)
            {
                selectedJanitor.Working = true;
                string trimmedName = selectedJanitor.Name.Trim(' ');
                Console.WriteLine($"{trimmedName} is now sweeping.\n");
            }
            else if (selectedJanitor.Working == true)
            {
                selectedJanitor.Working = false;
                string trimmedName = selectedJanitor.Name.Trim(' ');
                Console.WriteLine($"{trimmedName} has stopped sweeping.\n");
            }
        }

    }
}
