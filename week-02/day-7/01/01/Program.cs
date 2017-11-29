using System;

namespace SimpleReplace
{
    public class SimpleReplace
    {
        public static void Main(string[] args)
        {
            string wrongexample = "In a dishwasher far far away";

            string correctexample = wrongexample.Replace("dishwasher", "galaxy");

          
            // I would like to replace "dishwasher" with "galaxy" in this example, but it has a problem.
            // Please fix it for me!
            // Expected ouput: In a galaxy far far away

            Console.WriteLine(correctexample);
            Console.ReadKey();
        }
    }
}