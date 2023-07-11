using InterfacePractice.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
    // se citeste Dog extends (is an) Animal and implements IPet and IHunt
    internal class Dog : Animal, IPet, IHunt
    {
        public int Age { get; set; }
       //  public /*new*/ string Name { get; set; } //hides the inherited member


        public Dog()
        {
            base.Trick = "fetching...";
            this.Age = 5;
        }

        public void Hunt(string pray)
        {
            Console.WriteLine("My dog hunts " + pray);
        }

        public void Play()
        {
            Console.WriteLine("My dog plays " + Trick);
        }
    }
}
