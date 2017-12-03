using System;

namespace PrintAll
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] af = { 4, 5, 6, 7 };
            Console.WriteLine(af);
            for (int i = 0; i < af.Length; i++)
            {
                Console.WriteLine(af[i]);
            }
            // - Create an array variable named `af`
            //   with the following content: `[4, 5, 6, 7]`
            // - Print all the elements of `af`
            Console.ReadLine();
        }
    }
}