using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class Mammal
    {
        public int NumberOfLegs { get; set; }

        public virtual void Digest()
        {
            Console.WriteLine("Digesting");
        }
    }

    public class Horse : Mammal, IMovable
    {
        public override void Digest()
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            Console.WriteLine("The horse moves on its feet");
        }
    }

    public interface IMovable
    {
        void Move();
    }
}
