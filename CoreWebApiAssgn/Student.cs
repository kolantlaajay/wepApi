using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApiAssgn
{
    public class Student
    {
        public Student()
        {

        }
        public Student(int id1, string firstname1, string lastname1, string division1, string grade1)
        {
            id = id1;
            firstName = firstname1;
            lastName = lastname1;
            division = division1;
            grade = grade1;
        }
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        public string division { get; set; }
        public string grade { get; set; }
    }
}
