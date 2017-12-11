using System;

namespace Animal
{
    class MainClass
    {
        class Animal
        {
            public string name;
            public int age;
            public float happiness;

            public void PrintBase()
            {
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Age: " + age);
                Console.WriteLine("Happiness: " + happiness);
            }
            class Dog : Animal
            {
                public int SpotCount;

                public void Bark()
                {
                    Console.WriteLine("WUF!");
                    base.happiness += 0.1f;
                }
            }
            class Cat : Animal
            {
                public float Cuteness;
                public void Meow()
                {
                    Console.WriteLine("MEOW!");
                }
            }



            public static void Main(string[] args)
            {
                Dog spotty = new Dog();
                spotty.name = "Spotty";
                spotty.age = 4;
                spotty.happiness = 0.8f;
                spotty.SpotCount = 25;
                spotty.PrintBase();
                spotty.Bark();
                Console.WriteLine("New Happiness: " + spotty.happiness);
                Console.ReadKey();

                Console.WriteLine();

                Cat heisenberg = new Cat();
                heisenberg.name = "Heisenberg";
                heisenberg.age = 13;
                heisenberg.happiness = 0.3f;
                heisenberg.Cuteness = 0.4f;
                heisenberg.PrintBase();
                heisenberg.Meow();

                Console.ReadKey();

            }
        }
    }
}

