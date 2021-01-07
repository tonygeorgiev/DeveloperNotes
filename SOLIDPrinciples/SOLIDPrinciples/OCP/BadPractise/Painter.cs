using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciples.OCP.BadPractise
{
    public class Painter
    {
        private IEnumerable<Line> lines;
        private IEnumerable<Rectangle> rectangles;
        public void DrawAll()
        {
            ICanvas canvas = this.GetCanvas();
            foreach (var line in lines)
            {
                line.Draw(canvas);
            }
            foreach (var rectangle in rectangles)
            {
                rectangle.Draw(canvas);
            }
        }

        public ICanvas GetCanvas()
        {
            return new Canvas();
        }
    }

}