using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice.Animals
{
    // base class
    internal class Animal
    {
        public string Name { get; set; }
        public int MaxSpeed { get; set; }

        public Animal(string name, int maxSpeed)
        {
            Name = name;
            MaxSpeed = maxSpeed;
        }

        public void Swim()
        {
            Console.WriteLine("I am an animal and I can swim");
        }

        public void Walk()
        {
            Console.WriteLine("I am an animal and I can walk");
        }

        public void Fly()
        {
            Console.WriteLine("I am an animal and I can fly");
        }

        public void Crawl()
        {
            Console.WriteLine("I am an animal and I can crawl");
        }
    }

    class Mammals : Animal
    {
        public Mammals(string name, int maxSpeed) : base(name, maxSpeed)
        {
        }
    }

    class Fish : Animal
    {
        public Fish(string name, int maxSpeed) : base(name, maxSpeed)
        {
        }
    }

    class Birds : Animal
    {
        public Birds(string name, int maxSpeed) : base(name, maxSpeed)
        {
        }
    }
}
