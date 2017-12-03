using System;
using System.Linq;

namespace Reverse
{
    public class Reverse
    {
        public static void Main(string[] args)
        {
            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";
            reversed = RecursivelyReverseString(reversed);
            Console.WriteLine(reversed);
            Console.ReadLine();
        }

        public static string RecursivelyReverseString(string s)
        {
            if (s.Length > 0)
                return s[s.Length - 1] + RecursivelyReverseString(s.Substring(0, s.Length - 1));
            else
                return s;
          }
    }
}