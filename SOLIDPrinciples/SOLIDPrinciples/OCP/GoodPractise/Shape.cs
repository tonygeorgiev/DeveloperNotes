using SOLIDPrinciples.OCP.BadPractise;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciples.OCP.GoodPractise
{
    public abstract class Shape
    {
        public abstract void Draw(ICanvas canvas);
    }
}
