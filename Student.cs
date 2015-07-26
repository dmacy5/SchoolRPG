/*  Andrew Macy
                */
using System;

namespace SchoolRPG
{
    class Student : Character
    {
        private string grade { get { return grade; } set { grade = value; } }
        private string sexualPref { get { return sexualPref; } set { sexualPref = value; } }
        private int interest { get { return interest; } set { interest = value; } }
        private int attraction { get { return attraction; } set { attraction = value; } }

        public Student(string name) : base(name, "Student") { }

    }
}
