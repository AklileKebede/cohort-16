using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractExercise
{
    abstract class Wall
    {
        #region Properties
        public string Name { get;  }
        public string Color { get; }
        #endregion

        #region Constructor 
        public Wall(string name, string color)
        {
            this.Name = name;
            this.Color = color;
        }
        #endregion
        #region Method
        abstract public int GetArea();//public `GetArea()` takes no parameters and returns an integer representing the total area of the wall.
        #endregion
    }
}
