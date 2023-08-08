using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    internal static class StringExtensions
    {
        public static int WordCount(this string myString)
        {
            int count = myString.Split(' ').Length;
            return count;
        }

        public static int LetterCount(this string myString, int powerUp)
        {
            char[] charsToRemove = new char[] { '@', '_', ',', '.', '!' };
            var words = myString.Split(charsToRemove);

            int count = 0;
            foreach (var word in words)
            {
                count += word.Length;
            }

            var l = words.Sum(w => w.Length);
            Console.WriteLine($"Sum with lambda {l}");

            return count * powerUp;
        }
    }
}
