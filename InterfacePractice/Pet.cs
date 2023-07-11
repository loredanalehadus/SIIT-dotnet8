using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacePractice.Interfaces;

namespace InterfacePractice
{
    public class Pet : IPet // se citeste clasa Pet implements IPet interface
    {
        public string Trick { get; set; }

        public Pet(string trick)
        {
            Trick = trick;
        }

        public void Play()
        {
            Console.WriteLine("I like to play " + Trick);
        }
    }

    public class Toy : IPet
    {
        public string Trick { get; set; }

        public void Play()
        {
            Console.WriteLine("I play like a toy");
        }
    }
}
