using System;
using System.Collections.Generic;
using System.Text;

namespace Garden
{
    class Garden
    {
        public int ThirstyFlowers { get; set; }
        public int ThirstyTrees { get; set; }
        public List<Flowers> flowerList = new List<Flowers>();
        public List<Trees> treeList = new List<Trees>();
        Flowers flowers = new Flowers();
        Trees trees = new Trees();
        
        public void FlowerCreator(int amount, int waterAmount)
        {
            flowers.WaterAmount = waterAmount;
            for (int i = 0; i < amount; i++)
            {
                flowerList.Add(new Flowers());
            }
        }

        public void TreeCreator(int amount, double wateramount)
        {
            for (int i = 0; i < amount; i++)
            {
                treeList.Add(new Trees());
            }
        }

        public void Watering(double waterAmountToWater)
        {
            Console.WriteLine("\nWatering With: " + waterAmountToWater + "\n");
            if (flowers.WaterAmount < 5 )
            {
                flowers.WaterAmount = flowers.WaterAmount + (waterAmountToWater * 0.75)/ThirstyFlowers;
                

            }
            if (trees.WaterAmount < 10)
            {
                trees.WaterAmount = trees.WaterAmount + (waterAmountToWater * 0.40)/ThirstyTrees;
            }
        }

        public void ThirstyPlantHolder()
        {
            foreach (var flower in flowerList)
            {
                if (flowers.WaterAmount < 5)
                {
                    ThirstyFlowers++;
                }
                
            }

            foreach (var tree in treeList)
            {
                if(trees.WaterAmount < 10)
                {
                    ThirstyTrees++;
                }

            }
        }

        public void Printer()
        {
            foreach (var flower in flowerList)
            {            
                if (flowers.WaterAmount < 5)
                {
                    Console.WriteLine(flower.Colour + " flower does need water");
                }
                else
                {
                    Console.WriteLine(flower.Colour + " flower doesn't need water");
                }
            }

            foreach (var tree in treeList)
            {
                if (trees.WaterAmount < 10)
                {
                    Console.WriteLine(tree.Colour + " flower does need water");
                }
                else
                {
                    Console.WriteLine(tree.Colour + " flower doesn't need water");
                }
            }

        }
    }
}
