using System;
using System.Collections.Generic;
using System.Text;

namespace University_Clinic_Hospital
{
    class Janitor : Employee
    {
        public bool Sweeping { get; set; }
        public Janitor(bool sweeping) : base("", 0)
        {
            Sweeping = sweeping;
        }

    }
}
