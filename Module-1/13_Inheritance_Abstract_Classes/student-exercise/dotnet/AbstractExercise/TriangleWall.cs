using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractExercise
{
    class TriangleWall:Wall
    {
        #region Properties
        public int Base { get;}
        public int Height { get; }
        #endregion

        #region Constructor
        public TriangleWall(string name, string color, int @base, int height) : base(name, color)
        {
            this.Base = @base;
            this.Height = height;
        }
        #endregion
        #region Methods
        override public int GetArea()
        {
            return (this.Base * this.Height)/2;
        }
        override public string ToString()
        {
            return $"{this.Name} ({this.Base}x{this.Height}) triangle";
        }
        #endregion
    }
}
