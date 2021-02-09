using System;

namespace Shapes.Models
{
    /// <summary>
    /// A two-dimensional shape that can be drawn on the screen
    /// </summary>
    public class Shape2D
    {
        #region statics
        public static char edgeSymbol = '*';
        public static char fillSymbol = '*'; //'█';
        protected const double ASPECT_ADJUSTMENT = 0.45;
        #endregion

        #region Fields
        // A place to save the current color for restoring after the draw
        private ConsoleColor savedColor = ConsoleColor.White;
        #endregion

        #region Properties
        public ConsoleColor Color { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
<<<<<<< HEAD
        public bool IsFilled { get; set; }
        virtual public int Area
        {
            get // Area is a derived property (from the shape) there for it doesn't have a setter
            {
                return 0;// The Subclass that know the shape will override Area
            }
        }
        virtual public int Perimeter { get; set; }




        #endregion

        #region Constructors
        public Shape2D(int x, int y, ConsoleColor color, bool isFilled)

        {
=======
        public bool IsFilled{ get; set; }
        virtual public int Area 
        {
            get
            {
                return 0;
            }
        }
        
        virtual public int Perimeter
        { 
            get {
                return 0;
            }
        }
        #endregion

        #region Constructors
        public Shape2D(int x, int y, ConsoleColor color, bool isFilled) {
>>>>>>> 2a35320594bb288d1ed7d189c85c5727f0bfcad4
            this.X = x;
            this.Y = y;
            this.Color = color;
            this.IsFilled = isFilled;
        }
        #endregion


        #region Public Methods
<<<<<<< HEAD
        virtual public void Draw()
        {

        }

=======
        virtual public void Draw() { }
>>>>>>> 2a35320594bb288d1ed7d189c85c5727f0bfcad4
        #endregion

        #region Helper Methods
        protected void SetConsoleColor()
        {
            this.savedColor = Console.ForegroundColor;
            Console.ForegroundColor = Color;
        }

        protected void ResetConsoleColor()
        {
            Console.ForegroundColor = savedColor;
        }
        #endregion
    }
}

