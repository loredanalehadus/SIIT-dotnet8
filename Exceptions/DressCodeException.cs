using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class DressCodeException : ApplicationException
    {
        string errorMessage = "You are not dressed in the elf suit";
        
        public DressCodeException() : base()
        {
            Message = errorMessage;
            Console.WriteLine(errorMessage);
        }

        public new string Message { get; set; }

    }
}