using System;
using System.Collections.Generic;

namespace CollectionsPart1Lecture
{
    public class CollectionsPart1Lecture
	{
        static void Main(string[] args)
        {
			Console.WriteLine("####################");
			Console.WriteLine("       LISTS");
			Console.WriteLine("####################");
			
			List<string> characters;
			characters = new List<string>()
			{
				"Harry","Ron","Hermione"
			};

<<<<<<< HEAD
			
			

			// Grow the list by adding character to the end of the list
			characters.Add("Serverus");
			characters.Add("Albus");

            //Print the list by looping 
			for (int i=0;i<characters.Count;i++)
            {
				Console.WriteLine(characters[i]);
			}
            
=======
			List<string> characters;
			characters = new List<string>() 
			{
				"Harry",
				"Ron",
				"Hermione"
			};

			//add more to the end of the list
			characters.Add("Severus");
			characters.Add("Albus");

>>>>>>> 2a35320594bb288d1ed7d189c85c5727f0bfcad4

			Console.WriteLine("####################");
			Console.WriteLine("Lists are ordered");
			Console.WriteLine("####################");
			Console.WriteLine(characters[1]);

			Console.WriteLine("####################");
			Console.WriteLine("Lists allow duplicates");
			Console.WriteLine("####################");
<<<<<<< HEAD
			
			// with lists we can have duplicates
			characters.Add("Harry"); 
=======
			characters.Add("Harry");
>>>>>>> 2a35320594bb288d1ed7d189c85c5727f0bfcad4


			Console.WriteLine("####################");
			Console.WriteLine("Lists allow elements to be inserted in the middle");
			Console.WriteLine("####################");
<<<<<<< HEAD
			
			// Insert- adds a value to a specific index, everything else gets shifted down the list
			characters.Insert(1, "Hagrid");

			// TODO: Add multiple values at once
			// .AddRange only adds collection to end of slitheren
			string[] slitheren = new string[] { "Draco", "Crab", "Goyle" };
			characters.AddRange(slitheren);
			//InsertRange adds collection to a specific index of slitheren
			characters.InsertRange(4, slitheren);
=======
			characters.Insert(1, "Hagrid");

			//add a array into the list
			string[] slytherins = new string[] { "Draco", "Crabbe", "Goyle"};
			characters.AddRange(slytherins);

			//insert an arry in the middle
			string[] ravenclaw = new string[] { "Luna"};
			characters.InsertRange(7, ravenclaw);
>>>>>>> 2a35320594bb288d1ed7d189c85c5727f0bfcad4

			

			Console.WriteLine("####################");
			Console.WriteLine("Lists allow elements to be removed by index");
			Console.WriteLine("####################");
			characters.RemoveAt(1);

<<<<<<< HEAD
			// .RemoveAt removes
			characters.RemoveAt(1);
			// .Remove- the first value it comes to
			characters.Remove("Hermione");

			Console.WriteLine("####################");
			Console.WriteLine("Find out if something is already in the List");
			Console.WriteLine("####################");

            Console.WriteLine($"Is Hermione in the list? {characters.Contains("Hermione")}");
			Console.WriteLine($"Is Draco in the list? {characters.Contains("Draco")}");
=======
			
			Console.WriteLine("####################");
			Console.WriteLine("Find out if something is already in the List");
			Console.WriteLine("####################");
            Console.WriteLine($"Is Hermione in the list? {characters.Contains("Hermione")}");
>>>>>>> 2a35320594bb288d1ed7d189c85c5727f0bfcad4

			Console.WriteLine("####################");
			Console.WriteLine("Find index of item in List");
			Console.WriteLine("####################");
<<<<<<< HEAD

			Console.WriteLine($"Where is Hermione in the list? {characters.IndexOf("Hermione")}");
			Console.WriteLine($"Where is Draco in the list? {characters.IndexOf("Draco")}");

=======
			Console.WriteLine($"Where is Draco in the list? {characters.IndexOf("Draco")}");
>>>>>>> 2a35320594bb288d1ed7d189c85c5727f0bfcad4

			Console.WriteLine("####################");
			Console.WriteLine("Lists can be turned into an array");
			Console.WriteLine("####################");
<<<<<<< HEAD

			string[] charachtersAsArray = characters.ToArray();
			// Creat a new list from that array
			List<string> newList = new List<string>(charachtersAsArray);
=======
			string[] charactersAsArray = characters.ToArray();
>>>>>>> 2a35320594bb288d1ed7d189c85c5727f0bfcad4

			Console.WriteLine("####################");
			Console.WriteLine("Lists can be sorted");
			Console.WriteLine("####################");
<<<<<<< HEAD
            // Print the list with separator "," 
			Console.WriteLine(string.Join(",",characters));
			// .Sort only sorts by alphabetic order
			characters.Sort();
            Console.WriteLine(string.Join(",",characters));
=======
			characters.Sort();
			

>>>>>>> 2a35320594bb288d1ed7d189c85c5727f0bfcad4

			Console.WriteLine("####################");
			Console.WriteLine("Lists can be reversed too");
			Console.WriteLine("####################");
			characters.Reverse();


			//.Reverse will only reverse the list and not sort it
			characters.Reverse();

			Console.WriteLine("####################");
			Console.WriteLine("       FOREACH");
			Console.WriteLine("####################");
			Console.WriteLine();

<<<<<<< HEAD
			// Print all of teh characters

			// The For way...

			for (int i = 0; i < characters.Count; i++)
            {
				string character = characters[i];
				Console.WriteLine(characters);
            }
			Console.WriteLine("========================================");
			
			// The Foreach way...
			foreach (string character in characters)
            {
                Console.WriteLine(character);
            }
			// Crear the list
			characters.Clear();

			// Print the list
			Console.WriteLine("========================================");
			Console.WriteLine("Here are the new values: ");
			foreach (string character in characters)
			{
				Console.WriteLine(character);
			}

			List<int> scores = new List<int>() { 90, 87, 57, 67, 100, 87, 72 }; // int example with duplicates that is allowed in lists
			scores.Add(99); // .Add int value allways to the end of list
			Console.WriteLine(string.Join(" - ", scores)); // Print the list with separator " - "
			scores.Insert(0, 95); // .Insert(index,what);
			Console.WriteLine(string.Join(" - ", scores)); // Print list with insert with separator

			scores.RemoveAt(0); // find value in index 0 and then remove it
			Console.WriteLine(string.Join(" - ", scores)); // Print list with insert with separator
			scores.Remove(87); // find the first value that is 87 and then remove it
			Console.WriteLine($"Is there still an 87? {scores.Contains(87)}");

			scores.Sort(); //sort the scores from the lowest to highest

			//Add up all the scores and display an average
			int sum = 0;
			foreach (int score in scores)
			{
				sum += score;
			}
			Console.WriteLine($"Total: {sum}, Average score: {(double)sum / scores.Count}"); // we are casting the double to get an answer that is double

			/* If the list empty it will return for avrage "NaN"(Not a Number), because we will be dividing by 0
			in that case we can do an if score>0 */

			//Remove all the vlaues less then 75, we cannot use Foreach because we cannot add/remove values while in a Foreach 
			for (int i = 0; i < scores.Count; i++) // if we do i++ the we will skip indexs due to the shift while removing,
			{
				if (scores[i] < 75)
				{
					scores.RemoveAt(i);
					i--; // if we remove a value then it's indexs has went up, and to fix the i++
				}
			}
=======
			//print the list by looping
			for (int i = 0; i < characters.Count; i++)
			{
				Console.WriteLine(characters[i]);
			}

			
			foreach (string character in characters) {
				Console.WriteLine($"{character}");
            }
            Console.WriteLine("-------");
			characters.Clear();
            Console.WriteLine(characters.Count);
			foreach (string character in characters)
			{
				Console.WriteLine($"{character}");
			}



			List<int> scores = new List<int>() { 45,55,65,75};
			for (int i=0;i<scores.Count;i++) {
				if (scores[i]==55) {
					scores.Remove(55);
					i--;
                }
                
            }
>>>>>>> 2a35320594bb288d1ed7d189c85c5727f0bfcad4
		}
	}
}
