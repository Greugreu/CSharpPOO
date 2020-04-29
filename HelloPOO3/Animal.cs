using System;

namespace HelloPOO3
{
    public class Animal
    {
        // Class Constructors
        // Called when created, does the same things than PHP.

        public string race;
        
        //Constructor creation
        public Animal(string raceType)
        {
            race = raceType; // Set the inital value for type
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
         */
    }
}