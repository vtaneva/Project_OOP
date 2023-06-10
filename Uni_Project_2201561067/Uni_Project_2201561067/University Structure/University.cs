using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni_Project_2201561067.University_Structure
{
    class University
    {
        private String _name;
        private String _city;

        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public String City
        {
            get { return _city; }
            set { _city = value; }
        }
        public List<Faculty> Faculties { get; set; }
        public University(string name, string city, List<Faculty> faculties)
        {
            Name = name;
            City = city;
            Faculties = faculties;
        }
    }
}
