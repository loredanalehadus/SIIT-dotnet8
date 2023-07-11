using InterfacePractice.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
    internal class Wolf : Animal, IHunt
    {
        public void Hunt(string pray)
        {
            throw new NotImplementedException();
        }
    }
}
