using System;

namespace Lecture
{
    class Program
    {
        static bool sticky1(bool a) {
            Console.WriteLine("in sticky1");
            return a;
        }
        static bool sticky2(bool b) {
            Console.WriteLine("in sticky2");
            return b;
        }
        static bool sticky3(bool c) {
            Console.WriteLine("in sticky3");
            return c;
        }
        static void Main(string[] args)
        {
            bool a = true;
            bool b = true;
            bool c = true;
            if (sticky1(a) && sticky2(b) || sticky3(c)) {
                Console.WriteLine("in IF");
            }
            Console.WriteLine("done");
            /*****************************************************************************
            Part 1: Variable Scope
            ******************************************************************************/
            // Declare a variable
            int outerVariable = 100; 
            Console.WriteLine("Outervariable is " + outerVariable);
            
            // Start a statement block
            {
             // Print out the variable defined in the outer scope
                Console.WriteLine("Otervariable (from the inner block = " + outerVariable);

                // Declare a variable in the block (inner scope)   
                int innerVar = 200;

                // Print out that variable
                Console.WriteLine("InnerVar is \n\n" + innerVar);
            }




            // End the statement block

            // Print the the variable declared in the block


            /*****************************************************************************
            Part 2: Methods
            ******************************************************************************/
            // Call the MultiplyBy method


            // Create and print some boolean expressions

            int age = 13;
            if (age >= 18)
            {
                Console.WriteLine("You are an adult");
            }
            else
            {
                Console.WriteLine("You are a kid");
            }

            Console.WriteLine("This is the end for you");
        }

        /*
         * Create a method called MultiplyBy, which takes two integers and returns the integer product.
         */
    }
}
