using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me two Numbers: ");
            int num01 = Convert.ToInt32(Console.ReadLine());
            int num02 = Convert.ToInt32(Console.ReadLine());

            if(num01 > num02)
            {
                Console.WriteLine("The second number should be bigger" );
            }
            else if(num01 < num02)
            {
                for (int i = num01; i < num02; i++)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
            // Create a program that asks for two numbers
            // If the second number is not bigger than the first one it should print:
            // "The second number should be bigger"
            //
            // If it is bigger it should count from the first number to the second by one
            //
            // example:
            //
            // first number: 3, second number: 6, should print:
            //
            // 3
            // 4
            // 5
        }
    }
}