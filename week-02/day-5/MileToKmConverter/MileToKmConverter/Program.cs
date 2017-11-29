
using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the kilometers you want to convert :");
            string distance = Console.ReadLine();
            int km = int.Parse(distance);

            Console.WriteLine("The distance in miles:" + km * 1.609344);
            Console.ReadLine();




            // Write a program that asks for an integer that is a distance in kilometers,
            // then it converts that value to miles and prints it
        }
    }
}