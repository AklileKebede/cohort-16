using System;
using System.Diagnostics;

namespace Variables_And_Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            /* VARIABLES & DATA TYPES */

            /*
		    1. Create a variable to hold an int and call it numberOfExercises.
			Then set it to 26.
		    */
<<<<<<< HEAD
            int numberOfExercises = 26;
            Console.WriteLine(numberOfExercises);

=======
            int numberOfExercises;
            numberOfExercises = 1;
            Console.WriteLine(numberOfExercises);
            
>>>>>>> 2a35320594bb288d1ed7d189c85c5727f0bfcad4
            /*
            2. Create a variable to hold a double and call it half.
                Set it to 0.5.
            */
<<<<<<< HEAD
            double half = 0.5;
=======
            double half = .5;
>>>>>>> 2a35320594bb288d1ed7d189c85c5727f0bfcad4
            Console.WriteLine(half);

            /*
            3. Create a variable to hold a string and call it name.
                Set it to "TechElevator".
            */
            string name = "TechElevator";
            Console.WriteLine(name);

            /*
            4. Create a variable called seasonsOfFirefly and set it to 1.
            */
            int seasonsOfFirefly = 1;
            Console.WriteLine(seasonsOfFirefly);

            /*
            5. Create a variable called myFavoriteLanguage and set it to "C#".
            */
            string myFavoriteLanguage = "C#";
            Console.WriteLine(myFavoriteLanguage);

            /*
            6. Create a variable called pi and set it to 3.1416.
            */
            double pi = 3.1416;
            Console.WriteLine(pi);

            /*
            7. Create and set a variable that holds your name.
            */
<<<<<<< HEAD
            string myName = "Aklile";
            Console.WriteLine(myName);
=======
            string myName = "Ben";

>>>>>>> 2a35320594bb288d1ed7d189c85c5727f0bfcad4
            /*
            8. Create and set a variable that holds the number of buttons on your mouse.
            */
            int numberOfMouseButtons = 3;
<<<<<<< HEAD
            Console.WriteLine(numberOfMouseButtons);
=======

>>>>>>> 2a35320594bb288d1ed7d189c85c5727f0bfcad4
            /*
            9. Create and set a variable that holds the percentage of battery left on
            your phone.
            */
<<<<<<< HEAD
            double batteryPercentageLeft = 65;
            Console.WriteLine(batteryPercentageLeft);
=======
            int batteryLife = 3;


>>>>>>> 2a35320594bb288d1ed7d189c85c5727f0bfcad4
            /* EXPRESSIONS */

            /*
            10. Create an int variable that holds the difference between 121 and 27.
            */
<<<<<<< HEAD
            int difference = 121 - 27;
            Console.WriteLine(difference);
            /*
            11. Create a double that holds the addition of 12.3 and 32.1.
            */
            double sum = 12.3 + 32.1;
            Console.WriteLine(sum);
            /*
            12. Create a string that holds your full name.
            */
            myName = "Aklile Kebede";

=======
            int diff10 = 121 - 27;
            Console.WriteLine(diff10);

            /*
            11. Create a double that holds the addition of 12.3 and 32.1.
            */
            double addition11 = 12.3 + 32.1;
            Console.WriteLine(addition11);
            

            /*
            12. Create a string that holds your full name.
            */
            string myFullName = "Ben Kennedy";
            Console.WriteLine(myFullName);
>>>>>>> 2a35320594bb288d1ed7d189c85c5727f0bfcad4
            /*
            13. Create a string that holds the word "Hello, " concatenated onto your
            name from above.
            */
            string greeting = "Hello, " + myName;
            Console.WriteLine(greeting);
<<<<<<< HEAD
=======

>>>>>>> 2a35320594bb288d1ed7d189c85c5727f0bfcad4
            /*
            14. Add a " Esquire" onto the end of your full name and save it back to
            the same variable.
            */
            greeting = greeting + " Esquire";
            Console.WriteLine(greeting);
<<<<<<< HEAD
            /*
            15. Now do the same as exercise 14, but use the += operator.
            */
            greeting += " all aroung good guy";
            Console.WriteLine(greeting + " is funny"); //this is and expration
            /*
            16. Create a variable to hold "Saw" and add a 2 onto the end of it.
            */
            string saw = "Saw";
            saw += 2;
            Console.WriteLine(saw);
=======


            /*
            15. Now do the same as exercise 14, but use the += operator.
            */
            greeting += " Esquire";

            /*
            16. Create a variable to hold "Saw" and add a 2 onto the end of it.
            */
            string movie = "Saw" + 2;
            Console.WriteLine(movie);
>>>>>>> 2a35320594bb288d1ed7d189c85c5727f0bfcad4
            /*
            17. Add a 0 onto the end of the variable from exercise 16.
            */

            /*
            18. What is 4.4 divided by 2.2?
            */
            Console.WriteLine(4.4 / 2.2);
            /*
            19. What is 5.4 divided by 2?
            */
            Console.WriteLine(5.4 / 2);
            /* CASTING */

            /*
            20. What is 5 divided by 2?
            */
            Console.WriteLine(5 / 2); // gives the answer as 2 because type of numbers being recognized as integer

            /*
            21. What is 5.0 divided by 2?
            */
            Console.WriteLine(5.0 / 2); // gives 2.5 due to numbers being recognize as type double
            /*
            22. Create a variable that holds a bank balance with the value of 1234.56.
            */
            decimal balance = 1234.56M; // adding M to the end of number changes the type from double to decimal
            Console.WriteLine(balance);
            // another way to get a double into a decimal is 
            decimal myBal = (decimal)1234.56;
            Console.WriteLine(myBal);
            /*
            23. If I divide 5 by 2, what's my remainder?
            */
            Console.WriteLine(5 % 2);
            /*
            24. Create two variables: 3 and 1,000,000,000 and multiple them together. 
                What is the result?
            */
            int multiplicand = 3;
            long multiplier = 1_000_000_000;
            long product = multiplicand * multiplier;
            Console.WriteLine(product);

            /*
            25. Create a variable that holds a boolean called doneWithExercises and
            set it to false.
            */
            bool doneWithExercises = false;

            /*
            26. Now set doneWithExercise to true.
            */
            doneWithExercises = true;
            Console.WriteLine(doneWithExercises);

            //Console.ReadLine();
        }
    }
}
