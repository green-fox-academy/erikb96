using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Böködi Erik");
            name = Console.ReadLine();

            int CalculateAge(DateTime birthDay)
            {
                int years = DateTime.Now.Year - birthDay.Year;

                if ((birthDay.Month > DateTime.Now.Month) || (birthDay.Month == DateTime.Now.Month && birthDay.Day > DateTime.Now.Day))
                    years--;

                return years;

                // Define several things as a variable then print their values
                // Your name as a string
                // Your age as an integer
                // Your height in meters as a double
                // Whether you are married or not as a boolean
            }
    }
}