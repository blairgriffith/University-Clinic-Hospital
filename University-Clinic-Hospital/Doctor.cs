using System;
using System.Collections.Generic;
using System.Text;

namespace University_Clinic_Hospital
{
    class Doctor : Employee
    {
        public string Specialty { get; set; }
        public Doctor(string specialty) : base("", 0)
        {
            Specialty = specialty;

        }
    }
}
