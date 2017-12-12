using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class AsbestClass
    {
        public string className { get; set; }
        public List<Student> StudentList { get; set; }
        public List<Mentor> MentorList { get; set; }

        public AsbestClass(string className)
        {
            this.className = className;
        }

        public void AddStudent(Student OneStudent)
        {
            StudentList.Add(OneStudent);
        }

        public void AddMentor(Mentor OneMentor)
        {
            MentorList.Add(OneMentor);
        }

        public void Info()
        {
            Console.WriteLine("Asbest" + className + "class has " + StudentList.Count + " students and " + MentorList.Count + " mentors.");
        }

    }
}