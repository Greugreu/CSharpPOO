using System;

namespace HelloPOO
{
    class Program
    {
        static void Main(string[] args) // <- this is a method
        {
            /*
                A method is a bloc of code which runs when called.
                the structure is as it follows:
                
                (static) type Name(arguments)
                {
                }
                
                to review the present "Main" method.
                static : the method belong to the program class but not an object of the program
                void : the method doesn't return a value
                main() : name of the method
                string[] args : argument, the current argument is an array called args
             */
            
            MyMethod(); // <- call of the method$
            NewMethod("Liam"); // <- call the method with input going into argument
            NewMethod("Jenny");
            NewMethod("Anja");
        }

        static void MyMethod() // <- made a new method
        {
            Console.WriteLine("MyMethod has been executed"); // <- code of the method
        }
        
        // PARAMETERS AND ARGUMENTS
        /*
            Informations can be passed into a method as a parameter. It's in the argument ().
         */

        static void NewMethod(string fname) // <- passed an argument fname
        {
            Console.WriteLine(fname + " Lastname"); // <- we use the argument data into the code
        }
        
        /*
            Rest of methods usage is basically the same as PHP classes.
            Can define default parameter -> static void Mymethod(string fname = "Anna")
            Can define multiple parameters -> static void MyMethod(string fname, int age)
            
            Return Values, we can specify a return value to methods as PHP classes methods, though we have to specify type
         */
        
        static int ReturnEx(int x)
        {
            return 5 + x;
        }

        static void ReturnUse(string[] args)
        {
            Console.WriteLine(ReturnEx(3));
        }
        // output 8 (5+3)
        
        /*
            Named arguments, it's possible to send arguments with the key:value syntax
            It's useful when you have multiple parameters with default values and you want to change/call only one
         */

        static void NamedParams(string child1 = "Liam", string child2 = "Jenny", string child3 = "John")
        {
            Console.WriteLine(child3);
        }
        static void ChangeNamedParams(string[] args)
        {
            NamedParams("child3");
        }
        
        /*
            Method OVERLOADING
            With method overloading, multiple methods can have the same name with different parameters
            Examples:
                int MethOverload(int x);
                float MethOverload(float x)
                double MethOverload(double x, double y)
         */
        
        // instead of doing this
        static int PlusMethodInt(int x, int y)
        {
            return x + y;
        }

        static double PlusMethodDouble(double x, double y)
        {
            return x + y;
        }

        static void methOverload(string[] args)
        {
            int myNum1 = PlusMethodInt(8, 5);
            double myNum2 = PlusMethodDouble(4.3, 6.26);
            Console.WriteLine("Int: " + myNum1);
            Console.WriteLine("Double: " + myNum2);
        }
        
        // we can do this

        static int PlusMethod(int x, int y)
        {
            return x + y;
        }

        static double PlusMethod(double x, double y)
        {
            return x + y;
        }

        static void Overload(string[] args)
        {
            int myNum1 = PlusMethod(8, 5);
            double myNum2 = PlusMethod(4.3, 6.26);
            Console.WriteLine("Int: " + myNum1);
            Console.WriteLine("Double: " + myNum2);
        }
        
        // END METHODS NEXT HELLOPOO2

    }
}