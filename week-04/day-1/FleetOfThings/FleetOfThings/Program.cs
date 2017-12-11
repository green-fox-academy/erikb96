using System;

namespace FleetOfThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var fleet = new fleet();
            var todo1 = new Thing("Get milk");
            var todo2 = new Thing("Remove the obstacles");
            var todo3 = new Thing("Stand up");
            var todo4 = new Thing("Eat lunch");
            fleet.Add(todo1);
            fleet.Add(todo2);
            fleet.Add(todo3);
            fleet.Add(todo4);
            todo3.Complete();
            todo4.Complete();
            Print(todo1);
            Print(todo2);
            Print(todo3);
            Print(todo4);
            
            
            Console.ReadLine();

         
            // Create a fleet of things to have this output:
            // 1. [ ] Get milk
            // 2. [ ] Remove the obstacles
            // 3. [x] Stand up
            // 4. [x] Eat lunch
            // Hint: You have to create a Print method also
        }
        public static void Print(Thing t)
        {
            if (t.Completed == true )
            {
                Console.WriteLine("[x]"+ t.Name.ToString());
            }
            else
            {
                Console.WriteLine("[]" + t.Name.ToString());
            }
            
        }
    }
}
