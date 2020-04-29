using System;

namespace HelloPOO3
{
    public class Animal
    {
        // Class Constructors
        // Called when created, does the same things than PHP.

        public string species;
        public string race;
        public string fur;
        public int age;
        
        //Constructor creation
        public Animal(string animalSpecies, string animalRace, string furColor, int animalAge )
        {
            species = animalSpecies; // Set the inital value for type
            race = animalRace;
            fur = furColor;
            age = animalAge;
        }
        
        // The constructor name must match the class name, it cannot have a return type (like void or int)
        
        // CONSTRUCTOR PARAMETERS
        /*
            Like methods, constructor car take parameters
            
            public name(string varName)
            {
                var = varName
            }
            
            so previously constructor was
            
            public Animal()
            {
                race = "cat";
            }
            
            We changed for the above.
            Now we'll add more parameters to create a cat.
         */
    }
}