using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class NegativeIntegerInputException : Exception
    {
        public NegativeIntegerInputException(int[] values)
            : base("The following negative integer(s) are not allowed in this operation: " + string.Join(",", values))
        {

        }
    }
}
