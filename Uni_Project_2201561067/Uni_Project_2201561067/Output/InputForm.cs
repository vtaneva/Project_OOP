using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uni_Project_2201561067.Members;
using Uni_Project_2201561067.University_Structure;

namespace Uni_Project_2201561067.Output
{
    static class InputForm
    {
        private static List<University> UniversityList = new List<University>();
        private static List<Faculty> FacultyList = new List<Faculty>();
        private static List<Teacher> TeacherList = new List<Teacher>();
        private static List<Specialties> SpecialList = new List<Specialties>();
        private static List<Student> StudentList = new List<Student>();
        private static List<StudentsPerSpecialty> StudentsPerSpecList = new List<StudentsPerSpecialty>();

        public static List<University> CreateUniversity()
        {

            List<University> UniversityList = new List<University>();
            University university = null;

            Console.WriteLine("------------------------------------------\n");
            Console.WriteLine($"\tCREATE NEW UNIVERSITY\n");
            Console.WriteLine("------------------------------------------\n");
            Console.Write("Name: ");
            string uniName = Console.ReadLine();

            Console.Write("City: ");
            string city = Console.ReadLine();

            List<Faculty> faculty = CreateFaculty();

            university = new University(uniName, city, faculty);
            Console.WriteLine($"\tSuccessfully created a new university!\n");
            UniversityList.Add(university);

            return UniversityList;
        }
        public static List<Faculty> CreateFaculty()
        {
            string facultyy = "faculties";
            List<Faculty> FacultyList = new List<Faculty>();
            Faculty faculty = null;
            String answer = null;
            do
            {
         Input: Console.WriteLine($"How many {facultyy} do you want to add?");
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    Console.Write("\n");
                    Console.Write($"\tCREATE NEW FACULTY\n");
                    Console.Write("\n");
               
                    Console.Write("Name: ");
                    string facName = Console.ReadLine();
                    List<Specialties> specialties = CreateSpecialties();

                    faculty = new Faculty(facName, specialties);
                    FacultyList.Add(faculty);

                }
                answer = Validation.ValidationYN(facultyy);
                if (answer == "y")
                {
                    goto Input;
                }
                Console.WriteLine($"\tSuccessfully created a new faculty!:-)\n");
                if (answer.ToLower() != "y")
                {
                    break;
                }

            } while ((answer.ToLower() == "y"));

            return FacultyList;
        }

        public static List<Specialties> CreateSpecialties()
        {
            string specialtyName = "specialties";

            Specialties specialty = null;
            String answer = null;
            do
            {
                Console.Write("\n");
                Console.Write($"\tCREATE NEW SPECIALTY\n");
                Console.Write("\n");
            Input: Console.WriteLine($"How many {specialtyName} do you want to add?");
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Specialty name: ");
                    string specName = Console.ReadLine();
                    specialty = new Specialties(specName);
                    SpecialList.Add(specialty);
                }

                Console.WriteLine($"\n\tSuccessfully created new {specialtyName}!:-)\n");
                answer = Validation.ValidationYN(specialtyName);
                if (answer == "y")
                {
                    goto Input;
                }
                if (answer.ToLower() != "y")
                {
                    break;
                }

            } while ((answer.ToLower() == "y"));

            return SpecialList;
        }

        public static List<Student> CreateStudents()
        {
            string stu = "students";
            StudentsPerSpecialty st = null;
            List<Student> StudentList = new List<Student>();
            Student student = null;
            String answer = null;
            do
            {
                Console.WriteLine($"How many {stu} do you want to add?");
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    Console.Write("\n");
                Console.WriteLine($"\tCREATE NEW STUDENT\n");
                Console.Write("\n");
                Console.Write("First Name: ");
                string firstName = Console.ReadLine();

                Console.Write("Last Name: ");
                string lastName = Console.ReadLine();

                Console.Write("Birthday of student:(xx/xx/xxxx): ");
                DateTime birthDay = DateTime.Parse(Console.ReadLine());
                var validBirth = birthDay.ToShortDateString();

                Console.Write("Year of starting:(xx/xx/xxxx): ");
                DateTime yearOfStart = DateTime.Parse(Console.ReadLine());
                var validyear = birthDay.ToShortDateString();

                Console.Write("Faculty number: ");
                double facNum = double.Parse(Console.ReadLine());

                Console.WriteLine();
                foreach (var spe in SpecialList)
                {
                    Console.WriteLine(spe.TitleSpecialty.ToUpper());
                }

                bool sp = true;
                do
                {
                    Console.Write("\nChoose specialty from the options: ");
                    string specialty = Console.ReadLine().ToLower();

                    Specialties specialties = GetSpecialtyByName(specialty);

                    if (specialties != null)
                    {
                        List<Student> studentt = new List<Student>();
                        foreach (var speccc in SpecialList)
                        {
                            if (speccc.TitleSpecialty.ToLower() == specialty)
                            {
                                studentt.Add(new Student(firstName, lastName, birthDay, specialty, yearOfStart, facNum));
                            }
                        }
                        st = new StudentsPerSpecialty(studentt, specialties);
                        StudentsPerSpecList.Add(st);
                        student = new Student(firstName, lastName, birthDay, specialty, yearOfStart, facNum);
                        break;
                    }
                    else
                    {
                        sp = false;
                        Console.WriteLine("Specialty not found.");
                    }
                } while (sp == false);
                
                StudentList.Add(student);
                }
                answer = Validation.ValidationYN(stu);
                if (answer.ToLower() == "n")
                {
                    Console.WriteLine($"\n\tSuccessfully created a new students!:-)\n");
                    Menu.SecondMenu();
                }

            } while ((answer.ToLower() == "y"));

            return StudentList;

        }

        public static List<Teacher> CreateTeachers()
        {
            string teach = "teachers";
            List<Teacher> TeacherList = new List<Teacher>();
            Teacher teacher = null;

            String answer = null;
            do
            {
                Console.WriteLine($"How many {teach} do you want to add?");
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("------------------------------------------\n");
                    Console.WriteLine($"\t CREATE A NEW TEACHER\n");
                    Console.WriteLine("------------------------------------------\n");
                
                    Console.Write("First Name: ");
                    string firstName = Console.ReadLine();

                    Console.Write("Last Name: ");
                    string lastName = Console.ReadLine();

                    Console.Write("Subject of course: ");
                    String subject = Console.ReadLine();
                    teacher = new Teacher(firstName, lastName, subject);
                    Console.WriteLine($"\tSuccessfully created a new  teacher ");

                    TeacherList.Add(teacher);
                }
                answer = Validation.ValidationYN(teach);
                if (answer.ToLower() == "n")
                {
                    Menu.SecondMenu();
                }
            } while ((answer.ToLower() == "y"));

            return TeacherList;
        }
        static Specialties GetSpecialtyByName(string name)
        {
            return SpecialList.Find(u => u.TitleSpecialty.ToLower() == name);
        }

        public static void PrintMembers()
        {
            
            Console.Write("Write specialty and see students in it: ");
            string specialty = Console.ReadLine().ToLower();


            Specialties specialties = GetSpecialtyByName(specialty);
            if (specialties != null)
            {
                foreach (var stt in StudentsPerSpecList)
                {
                    foreach (var studenttt in stt.Students)
                    {
                        if (studenttt.Specialty == specialty)
                        {
                            Console.WriteLine("\t____________________________________________________________\n");
                            Console.WriteLine($"Student: {studenttt.FirstName} {studenttt.LastName}, Specialty: {stt.Specialties.TitleSpecialty} ");
                            Console.WriteLine("\t____________________________________________________________\n");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("No students found in the specified specialty.");

            }
            Console.WriteLine();

        }
        public static void PrintAllStudents()
        {
            foreach (var stt in StudentsPerSpecList)
            {
                foreach (var studenttt in stt.Students)
                {
                    Console.WriteLine("\t____________________________________________________________\n");
                    Console.WriteLine($"Student: {studenttt.FirstName} {studenttt.LastName}, Specialty: {stt.Specialties.TitleSpecialty} ");
                    Console.WriteLine("\t____________________________________________________________\n");
                }
            }
        }

        public static void PrintAllSpecialies()
        {
            foreach (var sspec in SpecialList)
            {
                Console.WriteLine("\t____________________________________________________________\n");
                Console.WriteLine($"Specialty: {sspec.TitleSpecialty} ");
                Console.WriteLine("\t____________________________________________________________\n");
            }
        }
    }
}
