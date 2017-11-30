using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 24;
            int out1 = 0;

            
                if (a % 2 == 0)
            { 
                Console.WriteLine(++out1);
                           
            }
            

            Console.ReadLine();
            // if a is even increment out by one

            int b = 9;
            string out2 = "";

            if (b < 10)
            {
                out2 = "More!";
            }
            else if (b > 20)
            {
                out2 = "Less!";
            }
            else
            {
                out2 = "Sweet!";
            }
            
                Console.WriteLine(out2);
                Console.ReadLine();

            int c = 123;
            int credits = 100;
            bool isBonus = false;

            if (credits >= 50 && isBonus == false)
            {
                c -= 2;
            }
            else if (credits <= 50 && isBonus == false)
            {
                c -= 1;

            }
          
            // if credits are at least 50,
            // and isBonus is false decrement c by 2
            // if credits are smaller than 50,
            // and isBonus is false decrement c by 1
            // if isBonus is true c should remain the same

            Console.WriteLine(c);
            Console.ReadLine();
            
            int d = 8;
            int time = 120;
            string out3 = "";

            if (d % 4 == 0 && time > 200)
            {
                out3 = "check";
            }
            else if (time > 200)
            {
                out3 = "Time out";
            }
            else
            {
                out3 = "Run Forest Run";
            }

            // if d is dividable by 4
            // and time is not more than 200
            // set out3 to "check"
            // if time is more than 200
            // set out3 to "Time out"
            // otherwise set out3 to "Run Forest Run!"

            Console.WriteLine(out3);
            Console.ReadLine();


        }
    }
}