using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Program;

namespace Classes
{
    internal class FootbalPlayer
    {
        // fields of the class
        private string name;
        private int age;

        // constructors
        // parameterless constructor
        public FootbalPlayer()
        {
            // creates the instance of the class
        }

        public FootbalPlayer(string name)
        {
            this.name = name;
        }

        // these are properties of the class
        public string Name
        {
            get { return "Mr." + name; }
            set { name = value; }
        }
        public string Country { get; set; } // automatic properties
        public double Rating { get; set; }
        public int Age
        {
            get { return age; }
            set
            {
                age = value > 0 ? value : 0;

                //if (value > 0)
                //{
                //    age = value;
                //}
                //else
                //{
                //    age = 0;
                //}
            }
        }


        public ZileleSaptamanii MatchDay { get; set; }
    }
}
