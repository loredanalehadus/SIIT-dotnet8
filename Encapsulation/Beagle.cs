using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Beagle : Dog
    {
        public void Play()
        {
            //base.Profile();
            base.Trick();
        }
    }
}
