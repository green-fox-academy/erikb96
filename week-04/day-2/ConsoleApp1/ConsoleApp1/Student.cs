using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Student : Person
    {
        public Student(string name, int age, string gender, string PreviousOrganization)
        {
            
            previousOrganization = PreviousOrganization;
            skippedDays = 0;
        }
        public Student()
        {
            Name = "Jane Doe";
            Age = 30;
            Gender = "Female";
            previousOrganization = "School of life";
            skippedDays = 0;

        }

        public string previousOrganization { get; set; }
        public int skippedDays { get; set; }

        public override void GetGoal()
        {
            Console.WriteLine("Be a junior software developer.");
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm " + Name + ", a " + Age + " year old" + Gender + " from "
                + previousOrganization + " who skipped " + skippedDays + "days from the course already.");
        }

        public int SkipDays(int numberOfDays)
        {
            skippedDays += numberOfDays;
            return skippedDays;
        }
    }
}
