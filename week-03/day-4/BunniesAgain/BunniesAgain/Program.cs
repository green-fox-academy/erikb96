using System;

namespace BunniesAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number: ");
            int numberofbunny = int.Parse(Console.ReadLine());
            Console.WriteLine(BunnyEars(numberofbunny));
            Console.ReadLine();
            
        }
        public static int BunnyEars (int number)
        {
            if (number == 0)
            {
                return 0;
            }
            else if (number % 2 == 0)
            {
                return 2 + BunnyEars(number - 1);
            }
            else
            {
                return 3 + BunnyEars(number - 1);
            }
        }
    }
}
// We have bunnies standing in a line, numbered 1, 2, ... The odd bunnies
// (1, 3, ..) have the normal 2 ears. The even bunnies (2, 4, ..) we'll say
// have 3 ears, because they each have a raised foot. Recursively return the
// number of "ears" in the bunny line 1, 2, ... n (without loops or multiplication).
