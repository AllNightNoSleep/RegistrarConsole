using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrarConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            SpecializationSeeding seed = new SpecializationSeeding();
            MainMenuPrompt();
        }

        static int GetResponse()
        {
            int value;
            string input = Console.ReadLine();
            if (!int.TryParse(input, out value))
            {
                Console.WriteLine("Error! Please enter proper figure!");
                Display.DisplayOptions();
            }
            return value;
        }

        public static void MainMenuPrompt()
        {
            Display.DisplayOptions("Main");
            switch (GetResponse())
            {
                case 1:
                    Display.DisplayOptions("Record");
                    InputRecordPrompt(GetResponse());
                    break;
                case 2:
                    Display.DisplayOptions("Record");
                    ViewRecordPrompt(GetResponse());
                    break;
                case 3:
                    Console.WriteLine();
                    MainMenuPrompt();
                    break;
                case 4:
                    Display.DisplayOptions("Exit");
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("Please enter proper figure!");
                    MainMenuPrompt();
                    break;
            }
        }

        static DateTime InputAndValidateDate()
        {
            DateTime date = new DateTime();
            string input = Console.ReadLine();
            try
            {
                date = Convert.ToDateTime(input);
            }
            catch
            {
                Console.WriteLine("Error! Please enter proper figure!");
                InputAndValidateDate();
            }
            return date;
        }

        public static StudentType GetStudentType()
        {
            return (StudentType)(GetResponse() - 1);
        }

        private static void InputRecordPrompt(int value)
        {
            if (value == 1) //student
            {
                InputForStudent();
            }
            else if (value == 2)//teacher
            {
                InputForTeacher();
            }
            else if (value == 3) //course
            {
                InputForCourse();
            }
            else
            {
                Console.WriteLine("Error!");
                MainMenuPrompt();
            }
        }

        private static void InputForCourse()
        {
            Course course = new Course();
            Display.InputThis("Course Name");
            course.Name = Console.ReadLine();
            Display.InputThis("Start Date");
            course.StartDate = InputAndValidateDate();
            Display.DisplayOptions("Category");
            course.Specialization = SpecializationSeeding.specializationList[GetResponse()];
        }

        private static void InputForTeacher()
        {
            Teacher teacher = new Teacher();
            Display.InputThis("Name");
            teacher.Name = Console.ReadLine();
            Display.InputThis("Birthdate");
            teacher.Birthdate = InputAndValidateDate();
            Display.DisplayOptions("Specializations");
            teacher.Specialization = SpecializationSeeding.specializationList[GetResponse()];
        }

        static void InputForStudent()
        {
            Student student = new Student();
            Display.InputThis("Name");
            student.Name = Console.ReadLine();
            Display.InputThis("Birthdate");
            student.Birthdate = InputAndValidateDate();
            Display.DisplayOptions("Student Type");
            student.StudentType = GetStudentType();
            int i = DbContext.InsertData<Student>(student);
        }

        private static void ViewRecordPrompt(int value)
        {
            
        }
    }
}
