using System;
using System.Collections.Generic;
using System.Text;

namespace Dice
{
    class Dice
    {
        public int D6 { get; set; }

        public void Roll()
        {
            Random r = new Random();
            D6 = r.Next(1,7);
        }
    }
}
