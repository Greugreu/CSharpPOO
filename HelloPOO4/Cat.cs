using System;

namespace HelloPOO4
{
    class Cat : Animal
    {
        public string race;
        public string fur;
        public int age;
        private int legs;
        
        public Cat(string animalRace, string furColor, int animalAge )
        {
            race = animalRace;
            fur = furColor;
            age = animalAge;
        }

        public int Legs
        {
            get => legs;
            set => legs = value;
        }

        public override void animalSound()
        {
            Console.WriteLine("The cat Meow");
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3} - {4} - {5} - {6}", age, fur, legs, race, height, weight, width);
        }
    }
    
    /*
        Difference with PHP, here we don't use "extends", inheritance is defined by ":" next to class name.
        
        public class Cat : Animal
        
        jumping straight to POLYMORPHISM.
        Polymorphism occurs when we have many classes related to each other by inheritance.
        Using polymorphism, we can inherit parent class methods and use them with child class, though when classes have the same mehtods
        the parent class method has priority, so we can put "virtual" setting to parent method and "override" in child mehtod so child mehtod
        will be called correctly.
        
        // ABSTRACT CLASSES
        /*
            Same as PHP. Abstract classes cannot be used to create objects, but can be inherited. So I changed Animal class to abstract,
            so Cat inherits Animal properties and now we can just call a new cat class with Animal properties.
        */
}