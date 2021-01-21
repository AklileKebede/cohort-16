namespace Individual.Exercises.Classes
{
    public class HomeworkAssignment
    {
        public int EarnedMarks { get; set; }
        public int PossibleMarks { get; private set; }
        public string SubmitterName { get; private set; }
        public string LetterGrade
        {
            get
            {
                if (this.PossibleMarks <= 0)
                {
                    return "??";
                }
                // Calculate the % based on earned/possible
                double percent = (this.EarnedMarks * 100.00) / this.PossibleMarks;

                // Determine letter grade from percentage
                if (percent >= 90)
                {
                    return "A";
                }
                else if (percent >= 80)
                {
                    return "B";
                }
                else if (percent >= 70)
                {
                    return "C";
                }
                else if (percent >= 60)
                {
                    return "D";
                }
                else 
                {
                    return "F";
                }


            }
        }
        public HomeworkAssignment(int possibleMarks, string submitterName)
        {
            this.PossibleMarks = possibleMarks;
            this.SubmitterName = submitterName;
        }
    }
}
