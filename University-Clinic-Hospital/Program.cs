using System;

namespace University_Clinic_Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            Hospital hospital = new Hospital();
            hospital.addEmployeesToList();
            hospital.listEmployees();
        }
    }
}
