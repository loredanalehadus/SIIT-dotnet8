using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class PrintingException : Exception
    {
        public PrintingException() : base()
        {
        }

        public PrintingException(string message)
            : base(message)
        {
        }
    }
}
