using System;
using System.Collections.Generic;
using System.Text;

namespace University_Clinic_Hospital
{
    public class Hospital
    {
        public List<Employee> employeeList = new List<Employee>();
        public List<Patient> patientList = new List<Patient>();

        Doctor Harold = new Doctor("Harold",34120,"Heart");
        Doctor Roberta = new Doctor("Roberta",45012,"Brain");
        Nurse Cindy = new Nurse("Cindy",59333,0);
        Nurse Robert = new Nurse("Robert",90210,0);
        Janitor Doug = new Janitor("Doug",86753);
        Janitor Joan = new Janitor("Joan",44074);
        Receptionist Sue = new Receptionist("Sue",21640);
        Receptionist Peter = new Receptionist("Peter",59203);

        public void AddEmployeesToList()
        {
            employeeList.Add(Harold);
            employeeList.Add(Roberta);
            employeeList.Add(Cindy);
            employeeList.Add(Robert);
            employeeList.Add(Doug);
            employeeList.Add(Joan);
            employeeList.Add(Sue);
            employeeList.Add(Peter);
        }

        //stretch: use GetType() to get type, then convert output of GetType() to usable format in switch case
        public void ListEmployees()
        {
            foreach (Employee employee in employeeList)
            {
                Console.WriteLine($"{employee.Name} {employee.EmployeeNumber} {employee.SalaryPaid}");
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

        public void PayEmployees(Employee employee)
        {
            
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

    }
}
