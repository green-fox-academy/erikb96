using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpie
{
    class Sharpie
    {
        public Sharpie(string color,float width )
        {
            color = color;
            width = width;
            inkAmount = 100;
            
        }

        public string Color { get; set; }
        public float Width { get; set; }
        public int inkAmount { get; set; }

        public void Use()
        {
            inkAmount--;
        }
        
    }
}
