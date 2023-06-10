using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uni_Project_2201561067.University_Structure;

namespace Uni_Project_2201561067.Members
{
    class StudentsPerSpecialty
    {
        public List<Student> Students { get; set; } = new List<Student>();
        public Specialties Specialties { get; set; }

        public StudentsPerSpecialty(List<Student> students, Specialties specialties)
        {
            Students = students;
            Specialties = specialties;
        }
    }
}
