using System;

namespace University_Clinic_Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(105, 30);
            Menu menu = new Menu();

            menu.MenuLoop();

        }
    }
}