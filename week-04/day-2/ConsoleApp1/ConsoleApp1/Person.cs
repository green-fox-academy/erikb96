﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Person
    {
        public Person(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public Person()
        {
            Name = "Jane Doe";
            Age = 30;
            Gender = "Female";
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }


        public virtual void Introduce()
        {
            Console.WriteLine("Hi, I'm " + Name + ", a " + Age + " year old " + Gender);
        }

        public virtual void GetGoal()
        {
            Console.WriteLine("My goal is: Live for the moment!");
        }
    }
}
