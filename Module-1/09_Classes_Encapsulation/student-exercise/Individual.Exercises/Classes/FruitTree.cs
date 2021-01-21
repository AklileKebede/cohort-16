namespace Individual.Exercises.Classes
{
    public class FruitTree
    {
        // Creat the Properties (prop)
        public string TypeOfFruit { get; private set; }
        public int PiecesOfFruitLeft { get; private set; }
       // Creat Constructer (same name as class usually) that accepts the parameters
        public FruitTree(string typeOfFruit, int startingPiecesOfFruit) 
        {
            // Use parameters to set the properties of the class
            this.TypeOfFruit = typeOfFruit;
            this.PiecesOfFruitLeft = startingPiecesOfFruit;
        }
        public bool PickFruit(int numberOfPiecesToRemove)//Create a bool method PickFruit that accepts an int called numberOfPiecesToRemove 
        {
            /*If there are enough pieces left on the tree,
             * it "picks" the fruit and updates PiecesOfFruitLeft by subtracting numberOfPiecesToRemove from it.*/
            if ( this.PiecesOfFruitLeft>0)
            {
                this.PiecesOfFruitLeft -= numberOfPiecesToRemove;
                return true;

            }
            return false;
        }

    }
}
