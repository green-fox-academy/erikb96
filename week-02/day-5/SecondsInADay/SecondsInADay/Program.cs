using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentHours = 15;
            int currentMinutes = 11;
            int currentSeconds = 42;

            int twentyfourhour = (24 * 60) * 60;
            int currenttime = (currentHours * 60)* 60 + currentMinutes * 60 + 42;
            int targetTime = twentyfourhour - currenttime;

            Console.WriteLine(targetTime + "    seconds remaining till tomorrow");
            Console.WriteLine(twentyfourhour + "    seconds consists a day");
            Console.WriteLine(currenttime + "   seconds passed till now");
               
            Console.ReadKey();

        }
    }
}