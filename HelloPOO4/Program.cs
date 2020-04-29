using System;

namespace HelloPOO4
{
    class Program
    {
        static void Main(string[] args)
        {
            // INHERITANCE
            /*
                Inheritance system is basically the same as PHP. Take back previous Animal class from POO3
                But I move Cat code into new Cat calls which will be child of Animal.
             */

            Cat myCat = new Cat("Main Coon", "Grey Scales", 6);
            Console.WriteLine("Your cat is a {2} years old {0} with {1} fur.", myCat.race, myCat.fur, myCat.age);
            myCat.animalSound();
            Console.WriteLine(string.Join(", ", myCat)); // <- Here I dump all myCat object properties
            // returns 6 - Grey Scales - 0 - Main Coon - 0 - 0 - 0. Last 3 zeros are Height, Width, Weight inhrerited from Animal.
        }
    }
}