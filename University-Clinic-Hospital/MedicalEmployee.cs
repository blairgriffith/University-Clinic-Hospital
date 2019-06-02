using System;
using System.Collections.Generic;
using System.Text;

namespace University_Clinic_Hospital
{
    public abstract class MedicalEmployee : Employee
    {
        public virtual void DrawBlood(Patient patient)
        {
            Console.WriteLine($"The patient's blood level is now {patient.BloodLevel}");
        }
        public virtual void CareForPatient(Patient patient)
        {
            Console.WriteLine($"The patient's health is now {patient.HealthLevel}");
        }
        public int ChooseCare()
        {
            Console.WriteLine("Please choose the type of care this employee will perform:");
            Console.WriteLine("1. Draw Blood");
            Console.WriteLine("2. Care for Patient");
            int careChoice = Convert.ToInt32(Console.ReadLine());
            return careChoice;
        }
    }
}
