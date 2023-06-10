using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Uni_Project_2201561067.Output
{
     static class Menu
    {
        public static void HomeScreen()
        {

            Console.WriteLine("\t\t Choose operation:");
            Console.WriteLine("Select:  (1) Create university");
            Console.WriteLine("============================================================");
            Console.WriteLine("<-------  Press 0 to exit  ------>\n");

            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("You picked operation 1\n");
                var UniversityList = InputForm.CreateUniversity();
                foreach (var university in UniversityList)
                {
                    Console.WriteLine("\t____________________________________________________________\n");
                    Console.WriteLine($"\tUniversity: {university.Name}");
                    Console.WriteLine("\t____________________________________________________________");
                }
            }
            else
            {
                Console.WriteLine("Exit from application.");
                Environment.Exit(0);
            }
        }
        public static void SecondMenu()
        {
           
                Console.WriteLine("\n\t\t Choose operation:");
                Console.WriteLine("Select:  (1) Create student");
                Console.WriteLine("         (2) Create teacher");
                Console.WriteLine("         (3) Print students per specialty");
                Console.WriteLine("         (4) Print all students");
                Console.WriteLine("         (5) Print all specialties");
                Console.WriteLine("         (6) Back to first menu");
                Console.WriteLine("============================================================");
                Console.WriteLine("<-------  Press 0 to exit  ------>\n");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("You picked operation 1\n");
                    var StudentList = InputForm.CreateStudents();
                }
                else if (choice == 2)
                {
                    Console.WriteLine("You picked operation 2\n");
                    var TeacherList = InputForm.CreateTeachers();
                }
                
                else if (choice == 3)
                {
                    Console.WriteLine("You picked operation 3\n");
                    InputForm.PrintMembers();
                }
                else if (choice == 4)
                {
                    Console.WriteLine("\nYou picked operation 4\n");
                    InputForm.PrintAllStudents();

                }
                else if (choice == 5)
                {
                    Console.WriteLine("You picked operation 5\n");
                    InputForm.PrintAllSpecialies();
                }
                else if (choice == 6)
                {
                    Console.WriteLine("You picked operation 6\n");
                    HomeScreen();
                }
                else
                {
                    Console.WriteLine("Exit from application.");
                    Environment.Exit(0);
                }
            
        }
    }
}
