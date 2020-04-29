using System;

namespace HelloPOO4
{
    abstract class Animal
    {
        protected double height;
        protected double width;
        protected double weight;
        
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }
}