using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how many chicken legs you are curious about: ");
            string chicken = Console.ReadLine();
            int legs = int.Parse(chicken);
            {
                if (legs < 2)

                    Console.WriteLine(chicken + "  chicken has  " + legs * 2 + "  legs");
                else
                    Console.WriteLine(chicken + "  chickens have  " + legs * 2 + "  legs");

            }
            

            Console.WriteLine("Enter how many pig legs you are curious about: ");
            string pig = Console.ReadLine();
            int piglegs = int.Parse(pig);
            {
                if (legs < 2)

                    Console.WriteLine(pig + "  pig has  " + piglegs * 4 + "  legs");
                else
                    Console.WriteLine(pig + "  pigs have  " + piglegs * 4 + "  legs");

            }


            Console.ReadLine();
            //Console.WriteLine(chicken + "chicken has" + legs * 2 + "legs");
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The seconf represents the number of pigs the farmer has
            // It should print how many legs all the animals have
        }
    }
}