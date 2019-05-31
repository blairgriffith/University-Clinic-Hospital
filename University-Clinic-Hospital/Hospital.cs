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

        public void addEmployeesToList()
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
        

    }
}
