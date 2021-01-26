using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Models
{
    public class Text : IDrawable
    {
        public int X { get; set; }
        public int Y { get; set ; }
        public string Lable { get; set; }
        public ConsoleColor Color { get; set; }
        public Text(int x, int y, ConsoleColor color, string lable)
        {
            this.X = x;
            this.Y = y;
            this.Color = color;
            this.Lable = lable;
        }

        public void Draw()
        {
            Console.CursorLeft = (int)(X * Console.WindowWidth / 100);
            Console.CursorTop = (int)(Y * Console.WindowHeight / 100);

            Console.ForegroundColor = Color; //Set the color

            Console.Write(Lable); // Write the text on the screen

            Console.ResetColor(); //Reset the screen color
        }

        public override string ToString() // Makes sure we get the text in output and not the methode name
        {
            return $"At ({X}, {Y}), a {this.Color} Text, with value '{this.Lable}'.";
        }

    }
}
