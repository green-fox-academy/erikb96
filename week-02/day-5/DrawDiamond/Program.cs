
using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many lines should the diamond have?");
            int lines = Convert.ToInt32(Console.ReadLine());
            string stars = "*";
            for (int i = 0; i < lines; i++)
                for (int e = i; e < lines; e++)
                {
                    Console.WriteLine(" ");
                }
            {
                Console.WriteLine(stars);
                stars += "**";
            }
            //for (int i = 0; i < lines; i--)
                for (int e = i; e < lines; e--)
                {
                    Console.WriteLine(" ");
                }
            {
                Console.WriteLine(stars);
                stars += "**";
               
                
            }
          
            Console.ReadLine();
            
            
            // Write a program that reads a number from the standard input, then draws a
            // diamond like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //  *****
            //   ***
            //    *
            //
            // The diamond should have as many lines as the number was

        }
    }
}