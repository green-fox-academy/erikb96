using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many lines should the triangle have?" );
            int lines = Convert.ToInt32(Console.ReadLine());
            string star = "*";
            for (int i = 0; i < lines; i++)
            {
            Console.WriteLine(star);
                star += "*";
            }
            Console.ReadKey();


            
            

            // Write a program that reads a number from the standard input, then draws a
            // triangle like this:
            //
            // *
            // **
            // ***
            // ****
            //
            // The triangle should have as many lines as the number was
        }

       
    }
}

