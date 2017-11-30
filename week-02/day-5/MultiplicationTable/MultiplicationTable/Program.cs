using System;

namespace GreenFox
{
    class Program
    {
        private static readonly int i;

        static void Main(string[] args)
        {
            Console.WriteLine("Give me that number you wan't to multiplicate: ");
            int yournumber = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 15; i++)
            {
                int result = i * yournumber;
                Console.WriteLine(i + " * " + yournumber + " = " + result); 

            }
            Console.ReadLine();
            // Create a program that asks for a number and prints the multiplication table with that number
            //
            // Example:
            // The number 15 should print:
            //
            // 1 * 15 = 15
            // 2 * 15 = 30
            // 3 * 15 = 45
            // 4 * 15 = 60
            // 5 * 15 = 75
            // 6 * 15 = 90
            // 7 * 15 = 105
            // 8 * 15 = 120
            // 9 * 15 = 135
            // 10 * 15 = 150
        }
    }
}
