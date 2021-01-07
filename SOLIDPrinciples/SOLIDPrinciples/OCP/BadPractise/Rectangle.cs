using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciples.OCP.BadPractise
{
    public class Rectangle
    {
        public void Draw(ICanvas canvas)
        { /* draw a line on the canvas */ }
    }
}
