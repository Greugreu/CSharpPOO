using System;

namespace HelloPOO2
{
    class Animal // <- Class name
    {
        /*
            Personal notes on syntax:
            To instantiate a new object, we have to use the class name before the object name
            cf. Arrows
            
            Class Members
            Fields and methods inside classes are often referred to as "Class Members"
         */
        
        public string name = "Cat"; // field
        public int maxRunningSpeed = 200; // field
        public void fullThrottle() // method
        {
            Console.WriteLine("The cat is going as fast as it can!");
        }
        
        // we also can leave fields blank and modify them when creating objects
        public string race;
        public int legs;

    }
}