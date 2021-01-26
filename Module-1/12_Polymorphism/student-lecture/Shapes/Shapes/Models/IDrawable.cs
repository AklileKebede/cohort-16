using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Models
{
    public interface IDrawable
    {
        int X { get; set; }// Property in interface doesn't need public, because everything in an interface is public
        int Y { get; set; }
        void Draw(); 
    }
}
