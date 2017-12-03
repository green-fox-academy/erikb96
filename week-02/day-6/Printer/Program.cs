using System;

namespace Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a function called `printer`
            //   which prints the input String parameters
            // - It can have any number of parameters

            // Examples
           // printer("first");
           // printer("first", "second");
            printer("first", "second", "third", "fourth");
            // ...
            Console.ReadLine();

            
        }
        static void printer(params string[] args)
        {
            for (int i = 0; i < args.Length; i++)  // iterator = sekvencialisan (sorban) csinál valamit
            {
                Console.WriteLine(args[i]);
            }

        }

    }
}