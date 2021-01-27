using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractExercise
{
    class SquareWall : RectangleWall
    {

        #region Properties
        public int SideLenght { get; }
        #endregion

        #region Constructor
        public SquareWall(string name, string color, int sideLength): base(name, color,sideLength,sideLength)
        {
            this.SideLenght = sideLength;
        }
        #endregion
        #region Methods
        override public int GetArea()
        {
            return this.SideLenght * this.SideLenght;
        }
        public override string ToString()
        {
            return $"{this.Name} ({this.SideLenght}x{this.SideLenght}) square";
        }
        #endregion
    }
}
