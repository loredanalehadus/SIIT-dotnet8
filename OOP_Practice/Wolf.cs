using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{
    internal class Wolf
    {
        public string FurColor { get; set; }

        public Wolf(string furColor)
        {
            FurColor = furColor;
        }

        public void Hibernate()
        {
            Console.WriteLine("Wolf says AUUU and hibernates");
        }

    }
}
