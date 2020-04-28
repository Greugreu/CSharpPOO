using System;

namespace HelloPOO2
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal myPet = new Animal(); // <- Animal class name have to be called before Obj name
            Console.WriteLine(myPet.name);
            Console.WriteLine(myPet.maxRunningSpeed);
            myPet.fullThrottle();
            myPet.race = "Main Coon";
            myPet.legs = 4;
            Console.WriteLine(myPet.race);
            Console.WriteLine(myPet.legs);
        }
    }
}

/*
    Create a class / object
    As PHP, to create a class use class keyword
    Objects refers to an instantiation 
    
    We created a new Animal.cs file that content our new class.
 */