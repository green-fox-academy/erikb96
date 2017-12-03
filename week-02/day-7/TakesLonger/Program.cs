using System;
using System.Text;

namespace TakesLonger
{
    public class TakesLonger
    {
        public static void Main(string[] args)
        {
            StringBuilder MyStringBuilder = new StringBuilder("Hofstadter's Law: It you expect, even when you take into account Hofstadter's Law.");
            
          
            MyStringBuilder.Insert(20, " always takes longer than ");

            Console.WriteLine(MyStringBuilder);
            Console.ReadLine();
            
            
            // When saving this quote a disk error has occured. Please fix it.
            // Add "always takes longer than" to the StringBuilder (quote) between the words "It" and "you"
            // Using pieces of the quote variable (instead of just redefining the string)
        }
    }
}