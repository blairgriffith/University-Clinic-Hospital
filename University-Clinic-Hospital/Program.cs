﻿using System;

namespace University_Clinic_Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            Doctor doctor = new Doctor("", 0, "");
            Nurse nurse = new Nurse("", 0, 0); ;
            Receptionist receptionist = new Receptionist("", 0);
            Janitor janitor = new Janitor("", 0);
            Patient patient = new Patient("");
            Hospital hospital = new Hospital();
            bool running = true;
            hospital.AddEmployeesToList();
            hospital.AddPatientsToList();

            Console.WriteLine("Welcome to University Clinic Hospital");
            do
            {
                Console.WriteLine("Please choose one of the following options:\n");
                Console.WriteLine("1. List Employees\n" +
                                  "2. Pay Employees\n" +
                                  "3. List Patients\n" +
                                  "4. Choose Employee for Task\n" +
                                  "5. Exit Program");
                int menuChoice = Convert.ToInt32(Console.ReadLine());
                switch (menuChoice)
                {
                    case 1:
                        hospital.ListEmployees();
                        break;
                    case 2:
                        hospital.PayEmployees();
                        break;
                    case 3:
                        hospital.ListPatients();
                        break;
                    case 4:
                        switch (hospital.ChooseEmployee().Type)
                        {
                            case "Doctor":
                                switch (doctor.ChooseCare())
                                {
                                    case 1:
                                        doctor.DrawBlood(hospital.ChoosePatient());
                                        break;
                                    case 2:
                                        doctor.CareForPatient(hospital.ChoosePatient());
                                        break;
                                }
                                break;
                            case "Nurse":
                                switch (nurse.ChooseCare())
                                {
                                    case 1:
                                        nurse.DrawBlood(hospital.ChoosePatient());
                                        break;
                                    case 2:
                                        nurse.CareForPatient(hospital.ChoosePatient());
                                        break;
                                }
                                break;
                            case "Receptionist":
                                receptionist.EndPhoneCall(receptionist);
                                break;
                            case "Janitor":
                                janitor.ChangeSweepingBehavior(janitor);
                                break;
                        }
                        break;
                    case 5:
                        running = false;
                        break;
                }
            } while (running == true);

        }
    }
}
