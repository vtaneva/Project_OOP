using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni_Project_2201561067.University_Structure
{
    class Faculty
    {
        private String _facName;

        public String TitleFaculty
        {
            get { return _facName; }
            set { _facName = value; }
        }
        public List<Specialties> Specialties { get; set; }
        public Faculty(string titleFac, List<Specialties> specialties)
        {
            TitleFaculty = titleFac;
            Specialties = specialties;
        }
    }
}
