using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrarConsole
{
    public static class Display
    {
        public static void InputThis(string display)
        {
            Console.WriteLine("Input "+ display + ": ");
        }

        private static void DisplayWithAutoNumberBullet(string [] names)
        {
            for (int i = 1; i < names.Count() + 1; i++)
            {
                Console.WriteLine("[" + i +"] " + names[i-1]);
            }
        }

        public static void DisplayOptions(string role = "Main")
        {
            if (role == "Main")
            {
                Console.WriteLine("School Registrar");
                Console.WriteLine("What do you wanna do?");
                DisplayWithAutoNumberBullet(new string[] { "Input Record", "View Record", "Main Menu", "Exit Application" });
            }
            if (role == "Record")
            {
                Display.InputThis(role + " of");
                DisplayWithAutoNumberBullet(new string[] { "Student", "Teacher", "Course" });
            }
            if (role == "Student Type")
            {
                Display.InputThis(role);
                DisplayWithAutoNumberBullet(new string[] { "New Student", "Returnee", "Short-term" });
            }
            if (role == "Specializations" || role == "Category")
            {
                Display.InputThis(role);
                string[] items = new string[SpecializationSeeding.specializationList.Count];
                for (int i = 0; i < SpecializationSeeding.specializationList.Count; i++)
                {
                    items[i] = SpecializationSeeding.specializationList[i].Name;
                }
                DisplayWithAutoNumberBullet(items);
            }
            if (role == "Display-Student")
            {
                Console.WriteLine();
                Student student = new Student();
            }
            if (role == "Exit")
            {
                Console.WriteLine("Thank you!");
            }
        }
    }
}
