using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPractice
{
    public class CustomList<T> // <T> makes the class generic
    {
        public void Add(T item)
        {
            Console.WriteLine(item);
            Console.WriteLine("Adding the item" );
        }

        public void Remove(T item)
        {
            Console.WriteLine("Removing the item");
        }
    }
}