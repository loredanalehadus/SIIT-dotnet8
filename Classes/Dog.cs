using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{



    //default is internal
    internal class Dog
    {
        // fields
        private string _name;
        string _owner; // private by default

        // Constants
        public const int LIVING_SPAN = 15;

        //readonly property
        public readonly DateTime dateOfBirth;

        // constuctors
        // used to initialize an object
        public Dog()
        {
            dateOfBirth = DateTime.Now;
        }

        public Dog(string name, string owner)
        {
            _name = name;
            _owner = owner;
        }

        // constructor cu parametri
        public Dog(string name, string breed, int birthYear)
        {
            Name = name;
            Breed = breed;
            BirthYear = birthYear;
        }

        //properties
        public string Name { get; set; }

        // write only property
        public string Breed { private get; set; }
        public int BirthYear { get; set; }

        //read only property
        public string NameAndOwner // dynamic property; se compune la runtime
        {
            get { return _name + " " + _owner; }
        }

        public int EstimatedDeathYear
        {
            get { return BirthYear + LIVING_SPAN; }
        }

        public void Bark()
        {
            Console.WriteLine("Ham Ham");
        }

        public void PrintDateOfBirth()
        {
            Console.WriteLine($"Birthdate is {dateOfBirth.ToLongDateString()}");
        }
    }
}
