using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Mentor : Person
    {
        public Mentor(string name, int age, string gender, string level)
        {
            Level = level; ;
        }
        public Mentor()
        {
            Level = "intermediate";
        }

        public string Level { get; set; }

        public override void GetGoal()
        {
            Console.WriteLine("Educate brilliant junior software developers.");
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm " + Name + ", a " + Age + " year old" + Gender + " " + Level + " mentor.");
        }


    }
}
