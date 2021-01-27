using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractExercise
{
    class RectangleWall : Wall
    {
        #region Properties
        public int Length { get;}
        public int Height { get;}
        #endregion
        #region Constructor
        public RectangleWall(string name, string color, int length, int height):base(name,color) //
        {
            this.Length = length;
            this.Height = height;
        }
        #endregion
        #region Methods
        override public int GetArea()
        {
            return this.Length * this.Height;
        }
        override public string ToString()
        {
            return $"{this.Name} ({this.Length}x{this.Height}) rectangle";
        }
        #endregion
    }
}
