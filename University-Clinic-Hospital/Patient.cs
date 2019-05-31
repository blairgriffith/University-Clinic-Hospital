using System;
using System.Collections.Generic;
using System.Text;

namespace University_Clinic_Hospital
{
    public class Patient
    {
        int BloodLevel { get; set; }
        int HealthLevel { get; set; }

        public Patient(int bloodLevel, int healthLevel)
        {
            BloodLevel = bloodLevel;
            HealthLevel = healthLevel;
        }
    }
}
