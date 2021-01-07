using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciples.ISP.BadPractise
{
    public class Dog : Animal
    {
        public override void Feed()
        {
            // Can be fed
            throw new NotImplementedException();
        }

        public override void Groom()
        {
            // Can be groomed
            throw new NotImplementedException();
        }
    }
}
