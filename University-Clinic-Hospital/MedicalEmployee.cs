using System;
using System.Collections.Generic;
using System.Text;

namespace University_Clinic_Hospital
{
    public abstract class MedicalEmployee : Employee
    {
        public abstract void DrawBlood(Patient patient);
        public abstract void CareForPatient(Patient patient);
    }
}
