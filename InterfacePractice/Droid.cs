using InterfacePractice.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
    internal class Droid : IHunt
    {
        public void Hunt(string pray)
        {
            Console.WriteLine("I hunt aliens");
        }
    }
}
