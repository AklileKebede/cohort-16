using System;
using System.Collections.Generic;
using System.Text;

namespace file_io_part1_exercises
{
    class Quiz_Question
    {
        /* 
        The class is creating a constructor that is taking a line in the file and creating feilds seperated by "|",
        then finding out if the answer is correct by seeing if it contains("*").
        Adding all the answers to a dictionary so we can display the choices of answers without knowing the number of answers
        Make sure to also to define that the feilds index 0 is the question.
        */
        public string Question { get; }
        public Dictionary<int, (string, bool)> answerOptions = new Dictionary<int, (string, bool)>(); // This is a field, not property
        

        public Quiz_Question(string questionAndAnswers)
        {
            
            string[] fields = questionAndAnswers.Split("|"); // Split "|" the line into individual fields 
            
            for (int i=1; i < fields.Length; i++)// string answer= fields[] froom index i=1 to fields.Length
            {
                if (fields[i].Contains("*")) //// contains.("*")
                {
                    fields[i]= fields[i].Replace("*","");
                    answerOptions[i] = (fields[i],true);
                }
                else
                {
                    answerOptions[i] = (fields[i], false);
                } 
            }
            this.Question = fields[0];
        }
    }
}
