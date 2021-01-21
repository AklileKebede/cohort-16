using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given the name of an animal, return the name of a group of that animal
         * (e.g. "Elephant" -> "Herd", "Rhino" - "Crash").
         *
         * The animal name should be case insensitive so "elephant", "Elephant", and
         * "ELEPHANT" should all return "herd".
         *
         * If the name of the animal is not found, null, or empty, return "unknown".
         *
         * "Rhino -> Crash"
         * "Giraffe","Tower"
         * "Elephant","Herd"
         * "Lion","Pride"
         * "Crow","Murder"
         * "Pigeon","Kit"
         * "Flamingo","Pat"
         * "Deer","Herd"
         * "Dog","Pack"
         * "Crocodile","Float"
         *
         * AnimalGroupName("giraffe") → "Tower"
         * AnimalGroupName("") -> "unknown"
         * AnimalGroupName("walrus") -> "unknown"
         * AnimalGroupName("Rhino") -> "Crash"
         * AnimalGroupName("rhino") -> "Crash"
         * AnimalGroupName("elephants") -> "unknown"
         *
         */
        public string AnimalGroupName(string animalName)
        {
            // creat new library
            Dictionary<string, string> animalDictionary = new Dictionary<string, string>()
            {
                { "Rhino".ToLower(), "Crash"},
                { "Giraffe".ToLower(),"Tower"},
                { "Elephant".ToLower(),"Herd"},
                { "Lion".ToLower(),"Pride"},
                { "Crow".ToLower(),"Murder"},
                { "Pigeon".ToLower(),"Kit"},
                { "Flamingo".ToLower(),"Pat"},
                { "Deer".ToLower(),"Herd"},
                { "Dog".ToLower(),"Pack"},
                { "Crocodile".ToLower(),"Float"},
            };
            // if animalName is Null then retun unkuknow
            if (animalName== null)
            {
                return "unknown";
            }

            // make all lowerCaseAnimal=animalName lowercase
            string lowerCaseAnimal = animalName.ToLower(); //RhiNo => rhino
            // loop the kvp lowerCaseAnimal
            
            foreach (KeyValuePair<string, string> kvp in animalDictionary)
            {
                if (kvp.Key == lowerCaseAnimal)
                {
                    return kvp.Value;
                }
            }
            return "unknown";
            // if animal name found then retun the kvp.value
            // else return "unknown"
        }
    }
}
