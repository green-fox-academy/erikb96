using System;

namespace GreenFox
{
    class Program
    {
        static void Main()
        {
            tryagain:
            Random rnd = new Random();
            int thoughtnumber = rnd.Next(1, 100);
            int lives = 5;
            Console.WriteLine("I've the number between 1-100. You have 5 lives.");

            again:

            int yournumber = Convert.ToInt32(Console.ReadLine());


            if (yournumber == thoughtnumber)
            {
                Console.WriteLine("Congratulations. You won!");
            } else
            {
                lives--;


                if (lives == 0)
                {
                    Console.WriteLine("Game Over");
                    goto tryagain;
                }

                else if (yournumber > thoughtnumber)
                {

                    Console.WriteLine("Too high.You have " + lives + " lives left.");
                    goto again;

                }
                else
                {

                    Console.WriteLine("Too low. You have " + lives + " lives left.");
                    goto again;
                }
            }


            Console.ReadLine();
                      
        }
    }
}