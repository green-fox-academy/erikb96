using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
        start:


            Console.WriteLine("Value of Numbers");
            int number = Convert.ToInt32(Console.ReadLine());
            Sum(number);
            Console.ReadKey();
        }
        static void Sum(int num)

        {
            int a = num * (num + 1) / 2;
            Console.WriteLine(a);
            goto start;

        }


        // - Write a function called `sum` that sum all the numbers
        //   until the given parameter

    }

}