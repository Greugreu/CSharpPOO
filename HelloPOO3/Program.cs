using System;

namespace HelloPOO3
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal Cat = new Animal("Cat"); // Create an Animal object called Cat (Constructor is called at the same time)
            Console.WriteLine(Cat.race);
            
        }
    }
}