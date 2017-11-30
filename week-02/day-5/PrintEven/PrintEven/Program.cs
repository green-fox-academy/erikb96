using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 500; i++)
            {
                if (i % 2 == 0) 
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();

            // Create a program that prints all the even numbers between 0 and 500
        }
    }
}