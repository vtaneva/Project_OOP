using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni_Project_2201561067.Members
{
    class Teacher : Person
    {
        private String _subject;

        public String Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }

        public Teacher(String lastName, String firstName, String subject) : base(lastName, firstName)
        {
            Subject = subject;
        }
    }
}
