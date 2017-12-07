using System;

namespace Bunny
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number: ");
            int numberofbunny = int.Parse(Console.ReadLine());
            Console.WriteLine(numberofbunny + " bunny have " + BunnyEarCalculator((numberofbunny)) + " ears.");
            Console.ReadLine();
            
        }
        public static int BunnyEarCalculator (int number)
        {
                     
            if (number == 1)
            {
                return 2 ;
            }
            else
            {
                
                return 2 + BunnyEarCalculator(number - 1);

            }
        }
    }
}
// We have a number of bunnies and each bunny has two big floppy ears.
// We want to compute the total number of ears across all the bunnies recursively (without loops or multiplication).
