using System;
using System.IO;

namespace CountLines
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Add a filename!");
                string myfile = Console.ReadLine();
                NumberOfLines(myfile);

            }
            catch
            {
                Console.WriteLine("0");
            }
            finally
            {
                Console.ReadLine();
            }
        }
        static void NumberOfLines (string filename)
        {
            string[] linesoffilename = File.ReadAllLines(filename);
            int numberoflines = linesoffilename.Length;
            Console.WriteLine(numberoflines);

        }
    }
}
// Write a function that takes a filename as string,
// then returns the number of lines the file contains.
// It should return zero if it can't open the file, and
// should not raise any error.