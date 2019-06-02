using System;
using System.Collections.Generic;
using System.Text;

namespace University_Clinic_Hospital
{
    class Menu
    {
        Menu menu = new Menu();
        Doctor doctor = new Doctor("", 0, "");
        Nurse nurse = new Nurse("", 0);
        Receptionist receptionist = new Receptionist("", 0);
        Janitor janitor = new Janitor("", 0);
        Patient patient = new Patient("");
        Hospital hospital = new Hospital();
        bool running = true;

        public void MenuLoop()
        {
            hospital.AddEmployeesToList();
            hospital.AddPatientsToList();
            Console.WriteLine("Welcome to University Clinic Hospital");
            Console.WriteLine("                                                                                                     ");
            Console.WriteLine("   ###    ###  #####   ###  ###  ###   ###  ########  ########   ######    ###   #######  ###     ###");
            Console.WriteLine("   ###    ###  ######  ###  ###  ###   ###  ########  ###   ##  ########   ###   #######   ###   ### ");
            Console.WriteLine("   ###    ###  ### ### ###  ###  ###   ###  ###       ###   ##  ##         ###     ###      #######  ");
            Console.WriteLine("   ###    ###  ### ### ###  ###   ### ###   ######    #######   ########   ###     ###        ###    ");
            Console.WriteLine("   ###    ###  ###  ######  ###    ## ##    ###       ########        ###  ###     ###        ###    ");
            Console.WriteLine("    ########   ###   #####  ###     ###     ########  ###   ##  ########   ###     ###        ###    ");
            Console.WriteLine("     #####     ###     ###  ###      #      ########  ###   ##   #####     ###     ###        ###    ");
            Console.WriteLine("\n                             Clinic Hospital Employee Management Software\n\n");
            do
            {
                switch (menu.MainMenu())
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
                        EmployeeActionMenu();
                        break;
                    case 5:
                        running = false;
                        break;
                }
            } while (running == true);
        }

        //Sub-menus
        public int MainMenu()
        {
            Console.WriteLine("Please choose one of the following options:\n");
            Console.WriteLine("1. List Employees\n" +
                              "2. Pay Employees\n" +
                              "3. List Patients\n" +
                              "4. Choose Employee for Task\n" +
                              "5. Exit Program");
            int menuChoice = Convert.ToInt32(Console.ReadLine());
            return menuChoice;
        }

        public void EmployeeActionMenu()
        {
            var chosenEmployee = hospital.ChooseEmployee();
            switch (chosenEmployee.Type)
            {
                case "Doctor      ":
                    switch (doctor.ChooseCare())
                    {
                        case 1:
                            doctor.DrawBlood(hospital.ChoosePatient());
                            break;
                        case 2:
                            doctor.CareForPatient(hospital.ChoosePatient(), chosenEmployee);
                            break;
                    }
                    break;
                case "Nurse       ":
                    switch (nurse.ChooseCare())
                    {
                        case 1:
                            nurse.DrawBlood(hospital.ChoosePatient());
                            break;
                        case 2:
                            nurse.CareForPatient(hospital.ChoosePatient(), chosenEmployee);
                            break;
                    }
                    break;
                case "Receptionist":
                    receptionist.ChangeWorking(chosenEmployee);
                    break;
                case "Janitor     ":
                    janitor.ChangeWorking(chosenEmployee);
                    break;
            }
        }


    }
}
