using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni_Project_2201561067.Members
{
    public abstract class Person
    {
        private String _firstName;

        public String FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        private String _lastName;
        public String LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public Person(String firstName, String lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
