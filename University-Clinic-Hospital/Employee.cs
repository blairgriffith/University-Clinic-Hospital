using System;
using System.Collections.Generic;
using System.Text;

namespace University_Clinic_Hospital
{
    public  class Employee
    {
        public string Name { get;set;}
        public int EmployeeNumber { get; set; }
        public string Salary { get; set; }
        public bool SalaryPaid { get; set; }

        public Employee ()
        {
            SalaryPaid = false;
        }

        public Employee AddEmployee()
        {
            Console.WriteLine("Please enter new employee's name:");
            this.Name = Console.ReadLine();
            Console.WriteLine($"Please assign {this.Name} a 5 digit employee number:");
            string number = Console.ReadLine();
            bool fiveDigitCheck;
            do
            {
                if (number.Length == 5)
                {
                    this.EmployeeNumber = Convert.ToInt32(number);
                    fiveDigitCheck = true;
                }
                else
                {
                    Console.WriteLine("Invalid entry. Please try again.");
                    fiveDigitCheck = false;
                }
            } while (fiveDigitCheck == false);

            return this;
        }

        
    }
}
