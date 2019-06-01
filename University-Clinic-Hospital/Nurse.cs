using System;
using System.Collections.Generic;
using System.Text;

namespace University_Clinic_Hospital
{
    public class Nurse : MedicalEmployee
    {
        public int NumberOfPatients { get; set; }
        public Nurse(string name, int employeeNumber, int numberOfPatients) : base()
        {
            Name = name;
            Type = "Nurse";
            EmployeeNumber = employeeNumber;
            Salary = "$50,000";
            NumberOfPatients = numberOfPatients;
        }
        
        public override void DrawBlood(Patient patient)
        {
            patient.BloodLevel -= 5;
        }

        public override void CareForPatient(Patient patient)
        {
            patient.HealthLevel += 7;
        }
    }
}
