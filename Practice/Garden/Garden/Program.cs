using System;

namespace Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            Garden garden = new Garden();

            garden.FlowerCreator(2, 5);
            garden.TreeCreator(2, 10);
            garden.flowerList[0].Colour = "yellow";
            garden.flowerList[1].Colour = "blue";
            garden.treeList[0].Colour = "purple";
            garden.treeList[1].Colour = "orange";

            garden.Printer();
            garden.Watering(40);
            garden.Printer();
            garden.Watering(70);
            garden.Printer();


            Console.ReadLine();

            
        }
    }
}
