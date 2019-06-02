using System;
using System.Collections.Generic;
using System.Text;

namespace University_Clinic_Hospital
{
    public class Hospital
    {
        public List<Employee> employeeList = new List<Employee>();
        Doctor doc1 = new Doctor("Harold  ",341205,"Heart");
        Doctor doc2 = new Doctor("Roberta ",450123,"Brain");
        Nurse nurse1 = new Nurse("Cindy   ",593331);
        Nurse nurse2 = new Nurse("Robert  ",902100);
        Janitor jan1 = new Janitor("Doug    ",867530);
        Janitor jan2 = new Janitor("Joan    ",440740);
        Receptionist recep1 = new Receptionist("Sue     ",216440);
        Receptionist recep2 = new Receptionist("Peter   ",592031);

        public void AddEmployeesToList()
        {
            employeeList.Add(doc1);
            employeeList.Add(doc2);
            employeeList.Add(nurse1);
            employeeList.Add(nurse2);
            employeeList.Add(jan1);
            employeeList.Add(jan2);
            employeeList.Add(recep1);
            employeeList.Add(recep2);
        }
        
        public List<Patient> patientList = new List<Patient>();
        Patient patient1 = new Patient("Gerald   ");
        Patient patient2 = new Patient("Geraldine");
        
        public void AddPatientsToList()
        {
            patientList.Add(patient1);
            patientList.Add(patient2);
        }

        //stretch: use GetType() to get type, then convert output of GetType() to usable format in switch case
        public void ListEmployees()
        {
            Console.WriteLine("Name     | Type         | Number | Salary  | Paid?");
            Console.WriteLine("---------|--------------|--------|---------|------");
            foreach (Employee employee in employeeList)
            {
                Console.WriteLine($"{employee.Name} | {employee.Type} | {employee.EmployeeNumber} | {employee.Salary} | {employee.SalaryPaid}");
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
            Console.WriteLine("Name       | Health Level | Blood Level ");
            Console.WriteLine("-----------|--------------|-------------");
            foreach (Patient patient in patientList)
            {
                Console.WriteLine($" {patient.Name} | {patient.HealthLevel}           | {patient.BloodLevel}");
   
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
            Console.WriteLine("\nPlease select an employee from the list:");
            int e = 0;
            foreach (Employee item in employeeList)
            {
                e++;
                Console.WriteLine($"{e}. {item.Name} -  {item.Type}");
            }
            int choice = Convert.ToInt32(Console.ReadLine()) - 1;
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
