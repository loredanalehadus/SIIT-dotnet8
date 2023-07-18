using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class Mammal
    {
        public int NumberOfLegs { get; set; }

        public virtual void Digest()
        {
            Console.WriteLine("Digesting");
        }
    }
}
