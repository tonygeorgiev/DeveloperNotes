using SOLIDPrinciples.OCP.BadPractise;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciples.OCP.GoodPractise
{
    public class Line : Shape
    {
        public override void Draw(ICanvas canvas)
        { /* draw a line on the canvas */ }
    }
}
