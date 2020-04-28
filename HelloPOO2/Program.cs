using System;

/*namespace HelloPOO2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}*/

/*
    Create a class / object
    As PHP, to create a class use class keyword
    Objects refers to an instenciation 
 */

class Animal // <- Class name
{
    string name = "Cat";

    static void Main(string[] args)
    {
        Animal myPet = new Animal(); // <- Animal class name have to be called before Obj name
        Console.WriteLine(myPet.name);
    }
    
    /*
        Personal notes on syntax:
        To instentiate a new object, we have to use the class name before the object name
        cf. Arrows
     */
}