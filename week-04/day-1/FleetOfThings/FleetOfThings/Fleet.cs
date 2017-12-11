using System;
using System.Collections.Generic;

namespace FleetOfThings
{
    public class fleet
    {
        private List<Thing> Things;

        public fleet()
        {
            Things = new List<Thing>();
        }

        public void Add(Thing thing)
        {
            Things.Add(thing);
        }
    }
}
