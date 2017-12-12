using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Sponsor : Person
    {
        public Sponsor(string name, int age, string gender, string Company)
        {
            company = Company;
        }
        public Sponsor()
        {
            company = "Google";
            hiredStudents = 0;
        }

        public string company { get; set; }
        public int hiredStudents { get; set; }

        public override void GetGoal()
        {
            Console.WriteLine("Hire brilliant junior software developers");
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm name, a age year old gender who represents company and hired hiredStudents students so far.");
        }
        public int Hire()
        {
            hiredStudents = hiredStudents + 1;
            return hiredStudents;
        }
    }
}