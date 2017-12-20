using System;

namespace Factorio
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a function called `factorio`
            //   that returns it's input's factorial
            var result = Factorio();
            Console.WriteLine(result);
            Console.ReadLine();
        }
        public static int Factorio()
        { 
            int number = int.Parse(Console.ReadLine());
            int factorial = 1;
            for (int i = number; i > 1; i--)
            {
                factorial = i * factorial;
            }
            return factorial;

        }
    }
}