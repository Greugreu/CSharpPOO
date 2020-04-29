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
        private int legs;
        
        //Constructor creation
        public Animal(string animalSpecies, string animalRace, string furColor, int animalAge )
        {
            species = animalSpecies; // Set the inital value for type
            race = animalRace;
            fur = furColor;
            age = animalAge;
        }

        public int Legs
        {
            get => legs;
            set => legs = value;
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
        
        // ACCESS MODIFIERS
        /*
            Classes properties and fields works the same as PHP, we can set access modifiers to regulate access.
            public        accessible for all
            private       only accessible within the same class
            protected     only accessible within same class or by inheritance
            internal      only accessible within it's own assembly, but not from another
         */
        
        // PROPERTIES AND ENCAPSULATION
        /*
            Encapsulation : It's to make sure that sensitive data is hidden from the user. To achieve it, declare private fields/variables
            provide public getters and setters through properties to access and update private fields.
            
            Properties : A property is a combination of variable and method and has a get and set method. 
            
            class Person
            {
                private string name;
                
                public string Name
                {
                    get { return name; }
                    set { name = value; } 
                }
            }
            
            for more clarity, I created a new field "Legs". As PHP, "Legs" field is set as private, can only be accessed by Legs getter
            and modified by "Legs" setter.
         */
        
        // AUTOMATIC PROPERTIES
        /*
            C# provides a way to quickly create automatic properties without defining a field before.
            
            class ClassName
            {
                public string Var
                { get; set; }
            }
         */
        
        // END; NEXT INHERITANCE IN HELLOPOO4
    }
}