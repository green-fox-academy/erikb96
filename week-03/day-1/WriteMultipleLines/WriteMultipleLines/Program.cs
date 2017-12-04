using System;
using System.IO;

namespace WriteMultipleLines
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // utasítások a usernek, userinput
                Console.WriteLine("Give me a path: ");
                string path = Console.ReadLine();
                Console.WriteLine("Give me a word: ");
                string word = Console.ReadLine();
                Console.WriteLine("Give me a number: ");
                int number = Convert.ToInt32(Console.ReadLine());

                // Átadjunk az inputokat egy funkciónak, ami belerakja egy fileba az adott szót annyi sorba amekkora számot adunk meg neki
                Parameters(path, word, number);


            }
            catch (Exception)
            {

                Console.WriteLine("Something went wrong");
            }
            finally
            {
                Console.ReadLine();
            }
        }

        //  belerakja egy fileba (path) az adott szót (word) annyi sorba amekkora számot (number) adunk meg neki
        static void Parameters(string path, string word, int number)
        {

            StreamWriter file = new StreamWriter(path);
                          

            for (int i = 0; i < number; i++)
            {
                file.WriteLine(word);                   
            }

            file.Close();

        }

       
    }
}
// Create a function that takes 3 parameters: a path, a word and a number,
// than it should write to a file.
// The path parameter should be a string, that describes the location of the file.
// The word parameter should be a string, that will be written to the file as lines
// The number paramter should describe how many lines the file should have.
// So if the word is "apple" and the number is 5, than it should write 5 lines
// to the file and each line should be "apple"
// The function should not raise any error if it could not write the file.