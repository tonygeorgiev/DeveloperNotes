using SOLIDPrinciples.OCP.BadPractise;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciples.OCP.GoodPractise
{
    public class Painter
    {
        private IEnumerable<Shape> shapes;
        public void DrawAll()
        {
            ICanvas canvas = GetCanvas();
            foreach (var shape in shapes)
            {
                shape.Draw(canvas);
            }
        }

        public ICanvas GetCanvas()
        {
            return new Canvas();
        }
    }
}
