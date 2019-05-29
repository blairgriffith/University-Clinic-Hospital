using System;
using System.Collections.Generic;
using System.Text;

namespace University_Clinic_Hospital
{
    public class Nurse : Employee
    {
        public int NumberOfPatients { get; set; }
        public Nurse(int numberOfPatients) : base("", 0)
        {
            NumberOfPatients = numberOfPatients;
        }

    }
}
