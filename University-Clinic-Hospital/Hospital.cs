using System;
using System.Collections.Generic;
using System.Text;

namespace University_Clinic_Hospital
{
    public class Hospital
    {
        public List<Employee> employeeList = new List<Employee>();
        Doctor harold = new Doctor("Harold",34120,"Heart");
        Doctor roberta = new Doctor("Roberta",45012,"Brain");
        Nurse cindy = new Nurse("Cindy",59333,0);
        Nurse robert = new Nurse("Robert",90210,0);
        Janitor doug = new Janitor("Doug",86753);
        Janitor joan = new Janitor("Joan",44074);
        Receptionist sue = new Receptionist("Sue",21640);
        Receptionist peter = new Receptionist("Peter",59203);

        public void AddEmployeesToList()
        {
            employeeList.Add(harold);
            employeeList.Add(roberta);
            employeeList.Add(cindy);
            employeeList.Add(robert);
            employeeList.Add(doug);
            employeeList.Add(joan);
            employeeList.Add(sue);
            employeeList.Add(peter);
        }
        
        public List<Patient> patientList = new List<Patient>();
        Patient gerald = new Patient("Gerald");
        Patient geraldine = new Patient("Geraldine");
        
        public void AddPatientsToList()
        {
            patientList.Add(gerald);
            patientList.Add(geraldine);
        }

        //stretch: use GetType() to get type, then convert output of GetType() to usable format in switch case
        public void ListEmployees()
        {
            foreach (Employee employee in employeeList)
            {
                Console.WriteLine($"{employee.Name} {employee.Type} {employee.EmployeeNumber} {employee.Salary} {employee.SalaryPaid}");
            }
            //foreach (Nurse nurse in employeeList)
            //{
            //    Console.WriteLine($"{nurse.Name} {nurse.EmployeeNumber} {nurse.SalaryPaid}");
            //}
            //foreach (Receptionist receptionist in employeeList)
            //{
            //    Console.WriteLine($"{receptionist.Name} {receptionist.EmployeeNumber} {receptionist.SalaryPaid}");
            //}
            //foreach (Janitor janitor in employeeList)
            //{
            //    Console.WriteLine($"{janitor.Name} {janitor.EmployeeNumber} {janitor.SalaryPaid}");
            //}
            Console.WriteLine("\n");
        }

        public void ListPatients()
        {
            foreach (Patient patient in patientList)
            {
                Console.WriteLine($" {patient.Name} {patient.HealthLevel} {patient.BloodLevel}");
   
            }
            Console.WriteLine("\n");
        }
        public void PayEmployees()
        {
            if (employeeList[0].SalaryPaid == true)
            {
                Console.WriteLine("Employees have already been paid.\n");
            }
            else
            {
                foreach (Employee employee in employeeList)
                {
                    employee.SalaryPaid = true;
                }
                Console.WriteLine("Employees have been paid.\n");
            }
            Console.WriteLine("\n");
        }

        public Employee ChooseEmployee()
        {
            Console.WriteLine("Please select an employee from the list:");
            int e = 0;
            foreach (Employee item in employeeList)
            {
                e++;
                Console.WriteLine($"{e}. {item.Name}");
            }
            int choice = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.WriteLine("\n");
            return employeeList[choice];
        }

        public Patient ChoosePatient()
        {
            Console.WriteLine("Please select a patient from the list:");
            int p = 0;
            foreach (Patient item in patientList)
            {
                p++;
                Console.WriteLine($"{p}. {item.Name}");
            }
            int choice = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.WriteLine("\n");
            return patientList[choice];
        }

    }
}
