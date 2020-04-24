using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.ExcercisesWithNumbers
{
    public class ArgumentIsNegativeException : ArgumentException
    {
        public ArgumentIsNegativeException()
        {
        }

        public ArgumentIsNegativeException(string message)
            :base(message)
        {
        }

        public ArgumentIsNegativeException(string message, Exception innerExciption)
            :base(message, innerExciption)
        {
        }
    }
}
