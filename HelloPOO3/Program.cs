using System;

namespace HelloPOO3
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal Cat = new Animal("Cat", "Main Coon", "Grey Scale", 6); // Create an Animal object called Cat (Constructor is called at the same time)
            Cat.Legs = 4;
            Console.WriteLine("Your pet is a {3} years old {0}, which is a {1} with {2} fur and {4} legs.", Cat.species, Cat.race,
                Cat.fur, Cat.age, Cat.Legs);
        }
    }
}