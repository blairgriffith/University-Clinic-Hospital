using System;
using System.Collections.Generic;
using System.Text;

namespace University_Clinic_Hospital
{
    class Receptionist : Employee
    {
        public bool OnPhone { get; set; }
        public Receptionist(bool onPhone) : base("", 0)
        {
            OnPhone = onPhone;
        }

    }
}
