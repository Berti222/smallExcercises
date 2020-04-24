using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.ExcercisesWithNumbers
{
    public class ArgumentIsZeroException : ArgumentException
    {
        public ArgumentIsZeroException()
        {
        }

        public ArgumentIsZeroException(string message)
            :base(message)
        {
        }

        public ArgumentIsZeroException(string message, Exception innerException)
            :base(message, innerException)
        {
        }
    }
}
