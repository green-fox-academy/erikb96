using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me two number to compare them:");
            int num01 = Convert.ToInt32(Console.ReadLine());
            int num02 = Convert.ToInt32(Console.ReadLine());


            if (num01 > num02) {
                Console.WriteLine(num01 + " Is bigger");
            }
            else if (num01 == num02) {
                Console.WriteLine("The two numbers are equal to each other");
            }

            else
            {
              
                Console.WriteLine(num02 + "Is bigger");
            }

            Console.ReadLine();

                // Write a program that asks for two numbers and prints the bigger one
            }
    }
}