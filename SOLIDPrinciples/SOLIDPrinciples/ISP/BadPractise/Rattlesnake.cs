using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciples.ISP.BadPractise
{
    public class Rattlesnake : Animal
    {
        public override void Feed()
        {
            // Can be fed
            throw new NotImplementedException();
        }

        public override void Groom()
        {
            // Can't be groomed
            throw new NotImplementedException();
        }
    }
}
