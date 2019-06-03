using System;
using System.Collections.Generic;
using System.Text;

namespace University_Clinic_Hospital
{
    public class Nurse : MedicalEmployee
    {
        public Nurse(string name, int employeeNumber) : base()
        {
            Name = name;
            Type = "Nurse       ";
            EmployeeNumber = employeeNumber;
            Salary = "$50,000";
            NumberofPatients = 0;
        }
        
        public override void DrawBlood(Patient patient)
        {
            patient.BloodLevel -= 5;
            base.DrawBlood(patient);
        }

        public override void CareForPatient(Patient patient, Employee employee)
        {
            patient.HealthLevel += 7;
            if (employee.NumberofPatients < 2)
            {
                employee.NumberofPatients++;
                base.CareForPatient(patient, employee);
            }
            string trimmed = employee.Name.Trim(' ');
            Console.WriteLine($"{trimmed} is now taking care of {employee.NumberofPatients} patients.\n");
        }
    }
}
