using System;

namespace Factorio
{
    class Program
    {
        static void Main(string[] args)
        {
            // displaying add number 
            Console.WriteLine("Add a number: ");

            // beolvassuk a userinputot, és konvertáljuk integer típusra 
            string userInput = Console.ReadLine();
            // gyozodjunk arrol hogy egy számot kaptunk
            int number;

            // string "123" <> int 123



            // TryParse - ha sikerul akkor a number egy integer lessz, ha nem akkor hibbát jelzzünk.
            if (Int32.TryParse(userInput, out number))
            {                
                // Factorial for number 5 is : 150
                Console.WriteLine("Factorial for number " + number + " is : " + Factorio(number));

            } else
            {
                Console.WriteLine(userInput + " is not a number!");
            }
            

            //int []
        
            // - Create a function called `factorio`
            //   that returns it's input's factorial
            Console.ReadLine();

        }

            public static int Factorio(int input)
        {
            // 5! = 5*4*3*2*1 , valtozoEredm;ny = n*(n-1)    
            int output = input;
            for (int i = 1; i < input; i++)
            {
                output = output * (input - i);
            }

            return output;        
        }
    }
}