using System;
using System.Collections.Generic;

namespace Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer("dfse");
            Printer("asfe");
            var printer = Printer("spdkof");
            foreach (var adottelem in printer)
            {
                Console.WriteLine(adottelem);
            }
            // - Create a function called `printer`
            //   which prints the input String parameters
            // - It can have any number of parameters

            // Examples
            // printer("first")
            // printer("first", "second")
            // printer("first", "second", "third", "fourh")
            // ...
            Console.ReadLine();
        }
        public static List<string> Printer(string input)
        {
            List<string> Print = new List<string>();
            Print.Add(input);
            return Print;
        }
    }
}