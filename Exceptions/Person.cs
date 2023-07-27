using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name
        {
            get { return this.name; }
            protected set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (this.age < 0)
                {
                    throw new ArgumentException("Age must be a positive number.");
                }

                if (this.age == 2)
                {
                    throw new DressCodeException();
                }

                this.age = value;
            }

        }
    }
}
