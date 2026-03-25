using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class NegativeIntegerInputException : Exception
    {
        public NegativeIntegerInputException() : base("This operation does not accept negative values. Please try again.")
        {

        }
    }
}
