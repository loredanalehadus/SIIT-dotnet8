using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Dog
    {
        public string Breed { get; }
        public string Name { get; set; }

        private void Profile()
        {
            Console.WriteLine("Dog profile is...");
        }

        protected void Trick()
        {
            Console.WriteLine("my trick is...");
        }

        public void Bark()
        {
            Console.WriteLine("ham ham");
        }
    }
}
