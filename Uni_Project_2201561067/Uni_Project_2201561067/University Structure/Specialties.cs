using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uni_Project_2201561067.Members;

namespace Uni_Project_2201561067.University_Structure
{
    class Specialties
    {
        private String _titleSpecialty;

        public String TitleSpecialty
        {
            get { return _titleSpecialty; }
            set { _titleSpecialty = value; }
        }

        public List<Student> Students = new List<Student>();

        public Specialties(String titleSpecialty)
        {
            TitleSpecialty = titleSpecialty;
        }
    }
}
