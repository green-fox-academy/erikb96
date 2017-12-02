using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add a number: ");
            int number = int.Parse(Console.ReadLine());
            double forave = 1;

            while (0 < 5)
            {
                Console.WriteLine("Add a number: ");
                int newnumber = int.Parse(Console.ReadLine());

                number = number + newnumber;
                int sum = number;
                forave = forave + 1;
                double sumforave = Convert.ToDouble(sum);
                double ave = sumforave / forave;

                Console.WriteLine("Sum: " + sum + ", Average: " + ave);
            }
            Console.ReadLine();
        }
    }
}