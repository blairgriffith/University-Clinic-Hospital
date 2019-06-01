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
        Patient gerald = new Patient();
        Patient geraldine = new Patient();
        
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

        }

        public void PayEmployees()
        {
            foreach (Employee employee in employeeList)
            if(employee.SalaryPaid == false)
            {
                employee.SalaryPaid = true;
                Console.WriteLine("Employees have been paid.");
            }
            else
            {
                Console.WriteLine("Employees have already been paid.");
            }
        }

        public Employee ChooseEmployee()
        {
            Console.WriteLine("Please select an employee from the list:");
            int i = 0;
            foreach (Employee item in employeeList)
            {
                i++;
                Console.WriteLine($"{i}. {item.Name}");
            }
            int choice = Convert.ToInt32(Console.ReadLine()) - 1;
            return employeeList[choice];
        }

    }
}
