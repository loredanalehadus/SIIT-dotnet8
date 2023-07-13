using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExplained
{
    public class Human //: Mammal
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public sealed class Mammal // nobody cannot inherit from here
    {

    }

}


