using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Write a function called `sum` that sum all the numbers
            //   until the given parameter
            Console.WriteLine("Give me a number: ");
            var result = Numbers();
            Console.WriteLine(result);
            Console.ReadLine();
        }
        public static int Numbers()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int result = num1 * num2;
            return result;
        }
        public static int Sum()
        {
            int input = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = input; i > 0; i--)
            {
                sum = i + sum;
            }
            return sum;
        }
    }
}