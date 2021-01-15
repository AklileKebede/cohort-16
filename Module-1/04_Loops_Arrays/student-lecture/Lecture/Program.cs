using System;

namespace Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Use a for-loop to print "Hello World" 10 times

            for (int i=1;i <=10;i=i+1)
            {
                Console.WriteLine("Hellow Wolld!");
            }

            // 2. Create an array of quiz scores
            int[] scores = new int[] { 90, 77, 70, 85 };
            
            // 3. Print all the scores to the screen
           
            Console.WriteLine("The scors are:\n");
            for (int i=0; i<scores.Length;i+=1)
            {
                Console.WriteLine(scores[i]);
            }

            // 4. Grade on a curve...increase all scores by the curve amount

            int curveAmount = 7;
            for (int i=0; i<scores.Length; i++)
            {
                scores[i] += curveAmount;
                Console.WriteLine($"{i++} Curved score {scores[i]}");
            }

            // 5. Calculate and print the average score for the class after the curve.

            int runingTotal = 0; //declare variable that is total of all scores

            for (int i=0; i<scores.Length; i++)
            {
                runingTotal += scores[i];
            }

            int averageScore = runingTotal / scores.Length;

            Console.WriteLine($"Average score is {averageScore}");

        }
    }
}
