/*  Andrew Macy
                */
using System;
using System.Collections.Generic;

namespace SchoolRPG
{
    class Teacher : Character, iNPC
    {
        private string subject;
        private List<Class> teaches;
        private Boolean testTime;
        
        public Teacher(string name, string subject, List<Class> teaches) : base( name, "Professor" )
        {
            this.subject = subject;
            this.testTime = false;
            this.teaches = teaches;
        }

        public Character interact(Character them)
        {
            return askQuestion(them);
        }

        public Character askQuestion(Character them)
        {
            Console.WriteLine(getQuestion());
            return them;
        }

        public string getQuestion()
        {
            return "";
        }
    }
}
