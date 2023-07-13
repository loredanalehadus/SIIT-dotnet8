using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.PeopleManagement
{
    public class Child : Person
    {
        public new int Age
        {
            get => base.Age;
            set
            {
                if (value > 15)
                {
                    throw new ArgumentException("Child's age cannot be more than 15");
                }

                base.Age = value;
            }
        }

    }
}
