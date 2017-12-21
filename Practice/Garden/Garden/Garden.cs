using System;
using System.Collections.Generic;
using System.Text;

namespace Garden
{
    class Garden
    {
        public List<Flowers> flowerList = new List<Flowers>();
        public List<Trees> treeList = new List<Trees>();

        public void FlowerCreator(int amount, int waterAmount)
        { 
            for (int i = 0; i < amount; i++)
            {
                flowerList.Add(new Flowers());
            }
        }
        public void TreeCreator(int amount, int wateramount)
        {
            for (int i = 0; i < amount; i++)
            {
                treeList.Add(new Trees());
            }
        }
    }
}
