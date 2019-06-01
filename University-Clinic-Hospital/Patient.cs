using System;
using System.Collections.Generic;
using System.Text;

namespace University_Clinic_Hospital
{
    public class Patient
    {
        public int BloodLevel { get; set; }
        public int HealthLevel { get; set; }

        public Patient()
        {
            BloodLevel = 20;
            HealthLevel = 10;
        }
    }
}
