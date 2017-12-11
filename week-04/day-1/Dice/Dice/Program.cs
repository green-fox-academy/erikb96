using System;

namespace Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice Dice1 = new Dice();


            Dice1.Roll();
            Console.WriteLine(Dice1.D6);
            Console.ReadLine();
        }
    }
}
