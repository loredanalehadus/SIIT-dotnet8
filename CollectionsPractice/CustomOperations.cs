using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPractice
{
    public class CustomOperations
    {
        public void Swap<T>(T item1, T item2)
        {
            T old = item1;
            item1 = item2;
            item2 = old;

            Console.WriteLine(item1);
            Console.WriteLine(item2);
        }
    }
}
