using System;

namespace University_Clinic_Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            Hospital hospital = new Hospital();
            bool running = true;
            Console.WriteLine("Welcome to University Clinic Hospital");
            do
            {
                Console.WriteLine("Please choose one of the following options:");
                Console.WriteLine("1. List Employees\n" +
                                  "2. Pay Employees\n" +
                                  "3. Choose Employee for Task\n" +
                                  "4. Exit Program");
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
                        switch (hospital.ChooseEmployee().Type)
                        {
                            case "Doctor":
                                break;
                            case "Nurse":
                                break;
                            case "Receptionist":
                                break;
                            case "Janitor":
                                break;
                        }
                        break;
                    case 4:
                        running = false;
                        break;
                }
            } while (running == true);

        }
    }
}
