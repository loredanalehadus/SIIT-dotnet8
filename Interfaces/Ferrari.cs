using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Ferrari : ICar
    {
        public string Model { get; private set; } // read only property

        public Ferrari(string model)
        {
            Model = model;
        }

        public void UseBrakes()
        {
            Console.WriteLine("Brakes!");
        }

        public void PushGasPedal()
        {
            Console.WriteLine("Wruuuuuuummmmm!");
        }
    }
}
