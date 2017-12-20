using System;

namespace AppendA
{
    class Program
    {
        static void Main(string[] args)
        {
            string am = "kuty";
            appendA(am);
            Console.ReadLine();
        }
        public static void appendA(string am)
        {
            Console.WriteLine(am + "a");
        }
        // - Create a string variable named `am` and assign the value `kuty` to it
        // - Write a function called `appendA` that gets a string as an input
        //   and appends an 'a' character to its end
        // - Print the result of `appendA(am)`
    }
}