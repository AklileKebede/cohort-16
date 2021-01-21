using System;

namespace CarSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Car using the default constructor.  Can I see any private members?
            // TODO: Later, use a "better" constructor
            Car mikeCar = new Car();

           

            Console.WriteLine($"Mike's car is {mikeCar.Color} and it is {mikeCar.Age} years old.");




            // Set the cars properties: Make, model, year. Try to set its Age.
            Car secondCar = new Car(2008, "Shevi", "Cobolt"); // another way to set properties while calling the constructer

            mikeCar.Color = "Beige"; // set
            mikeCar.Year = 2015;// setet=> since we provide this the Age will change because it goes through the 'geter'
            mikeCar.Make = "Toyota";// set
            mikeCar.Model = "Corolla";// set
            
            // mikeCar.Age = 2; // Cannot be done becasue there is no 'set' becasue Age has only a 'get'!!!

            // Create a new Car object (Create a new object of type Car)


            // Display the car property values, including Age


            // Try to put the car into gear
            mikeCar.Gear = "R"; //make the gear- this will go to 'get'
            Console.WriteLine($"mike's car is now in {mikeCar.Gear} gear");
            mikeCar.Gear = "D"; // this cannot happen because we 'set' condition that prevents changing the gear from R to D
            Console.WriteLine($"mike's car is now in {mikeCar.Gear} gear");

            // Speed up to 60mph
            while (mikeCar.Speed < 60)
            {
                mikeCar.Accelerate();
                // When the car hits 20mph, try to put it into Reverse
                Console.WriteLine($"Your speed is now {mikeCar.Speed}");
            }
            

            // Now let's brake hard. (Call the overloaded Accellerate)
            while (mikeCar.Speed > 0)
            {
                mikeCar.Accelerate(-5);
                Console.WriteLine($"Your speed is now {mikeCar.Speed}");
            }
        }
    }
}
