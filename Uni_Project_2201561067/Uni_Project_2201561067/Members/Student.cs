using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni_Project_2201561067.Members
{
    class Student : Person
    {
        private DateTime _birthDay;
        private string _spec;
        private DateTime _yearOfStart;
        private double _facNum;
        public DateTime BirthDay
        {
            get { return _birthDay; }
            set { _birthDay = value; }
        }

        public string Specialty
        {
            get { return _spec; }
            set { _spec = value; }
        }
        public DateTime YearOfStart
        {
            get { return _yearOfStart; }
            set { _yearOfStart = value; }
        }
        public double FacultyNumber
        {
            get { return _facNum; }
            set
            {  _facNum = value;  }
        }
        public Student(String FirstName, String LastName, DateTime birthTime, string specialty, DateTime year, double fac) : base(FirstName, LastName)
        {
            BirthDay = birthTime;
            Specialty = specialty;
            YearOfStart = year;
            FacultyNumber = fac;

        }
    }
}
