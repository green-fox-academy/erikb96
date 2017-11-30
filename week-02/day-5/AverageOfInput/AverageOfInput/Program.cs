using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me five numbers to calculate their sums and averages :");
            int num01 = Convert.ToInt32(Console.ReadLine());
            int num02 = Convert.ToInt32(Console.ReadLine());
            int num03 = Convert.ToInt32(Console.ReadLine());
            int num04 = Convert.ToInt32(Console.ReadLine());
            int num05 = Convert.ToInt32(Console.ReadLine());

            int sum = num01 + num02 + num03 + num04 + num05;
            double averege = sum / 5;

            Console.WriteLine( "Sum: " + (sum) + "," + "Average:" + (averege) );
            Console.ReadLine();
            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4
        }
    }
}