using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd =  new Random();
            int thoughtnumber = rnd.Next(1, 20);

            again:
            
            Console.WriteLine("Which number do i think?");
            int yournumber = Convert.ToInt32(Console.ReadLine());

            if (yournumber == thoughtnumber)
            {
                Console.WriteLine("You found the number: " + thoughtnumber);
            }
            else if (yournumber > thoughtnumber)
            {
                Console.WriteLine("The stored number is lower");
                goto again;
            }
            else
            {
                Console.WriteLine("The stored number is higher");
                goto again;
            }
            Console.ReadLine();
          
        }
    }
}