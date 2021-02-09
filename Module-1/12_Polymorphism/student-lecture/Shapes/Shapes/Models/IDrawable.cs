using System;
using System.Collections.Generic;
using System.Text;

<<<<<<< HEAD
namespace Shapes.Models
{
    public interface IDrawable
    {
        int X { get; set; }// Property in interface doesn't need public, because everything in an interface is public
        int Y { get; set; }
        void Draw(); 
=======
namespace Shapes.Models {
    interface IDrawable {

        int X { get; set; }
        int Y { get; set; }
        void Draw();

>>>>>>> 2a35320594bb288d1ed7d189c85c5727f0bfcad4
    }
}
