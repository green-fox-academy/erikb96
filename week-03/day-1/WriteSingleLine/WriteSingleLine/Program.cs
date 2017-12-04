using System;
using System.IO;

namespace WriteSingleLine
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"my-file.txt";

            try
            {
                if(path == @"my-file.txt")
                {
                    StreamWriter file = new StreamWriter(path);
                file.WriteLine("Böködi Erik");
                    file.Close();

                }
                else
                {
                    throw new Exception();
                }
                
                
                
             

            }
            catch (Exception)
            {
                Console.WriteLine("Unable to write file: my-file.txt");

            }
            finally
            {
                Console.ReadLine();
            }
            
        }
    }
}
// Open a file called "my-file.txt"
// Write your name in it as a single line
// If the program is unable to write the file,
// then it should print an error message like: "Unable to write file: my-file.txt"
