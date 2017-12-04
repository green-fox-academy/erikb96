using System;
using System.IO;

namespace CopyFile
{
    class Program
    {
        static void Main(string[] args)
        {


            // 1. Adjon megy egy új nevet, amire átmásolná a OldFile.txt-t

            Console.WriteLine("We will copy the OldFile.txt. Please enter the name of the new file: ");
            string name = Console.ReadLine();


            // 2. Meghívjuk a CopyFile funkciónkat, ami megkapja a OldFile.txt-t és a User által megadott új nevet
            bool result=CopyFile(@"OldFile.txt", name);

            // 3. Visszajelzünk a Usernek,hogy sikerült e vagy nem.
            if(result == true)
            {
                Console.WriteLine("OldFile.txt was succesfuly copied to: " + name);

            }
            else
            {
                Console.WriteLine("OldFile.txt was not copied to: " + name);
            }
            Console.ReadLine();

        }

        static bool CopyFile(string fileFrom, string fileTo)
        {
            try
            {
                StreamWriter newFile = new StreamWriter(fileTo);
                string[] oldFileLines = File.ReadAllLines(fileFrom);

                /*
                for (int i=0; i < oldFileLines.Length; i++)
                {
                    newFile.WriteLine(oldFileLines[i]);
                }
                */


                foreach (var oldFileLine in oldFileLines)
                {
                    newFile.WriteLine(oldFileLine);
                }
                

                newFile.Close();
            }
            catch (Exception)
            {

                return false;
            }

            return true;
           
        }
    }
}
// Write a function that reads all lines of a file and writes the read lines to an other file (a.k.a copies the file)
// It should take the filenames as parameters
// It should return a boolean that shows if the copy was successful