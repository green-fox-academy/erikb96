using System;
using System.Linq;

namespace Reverse
{
    public class Reverse
    {
        public static void Main(string[] args)
        {
            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";

            string resultreversed = string.Join(" ", reversed.Split(' ').Select(x => new String(x.Reverse().ToArray())));
            

            Console.WriteLine(resultreversed);
            Console.ReadLine();
        }
        
        // Create a function that can reverse a String, which is passed as the parameter
        // Use it on this reversed string to check it!
    }
}