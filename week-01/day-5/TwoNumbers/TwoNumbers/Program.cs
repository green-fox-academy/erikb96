using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 13;
            a += 22;
            Console.WriteLine(a);

            int b = 22;
            b -= 13;
            Console.WriteLine(b);

            int c = 22;
            c *= 13;
            Console.WriteLine(c);

            float d = 22;
            d /= 13;
            Console.WriteLine(d);

            int e = (int) d;
            Console.WriteLine(e);

            Console.WriteLine(22 % 13);


            Console.ReadLine();
            // Create a program that prints a few operations on two numbers: 22 and 13

            // Print the result of 13 added to 22

            // Print the result of 13 substracted from 22

            // Print the result of 22 mutiplied by 13

            // Print the result of 22 divided by 13 (as a decimal fraction)

            // Print the integer part of 22 divided by 13

            // Print the reminder of 22 divided by 13
        }
    }
}