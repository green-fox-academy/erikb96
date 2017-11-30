using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            {
                if (num % 2 == 0)
                    Console.WriteLine(num + " Is an Even Number");


                else
                    Console.WriteLine(num + " Is an Odd number");
            }

            
            Console.ReadLine();
                

            // Write a program that reads a number from the standard input,
            // Then prints "Odd" if the number is odd, or "Even" if it is even.

        }
    }
}