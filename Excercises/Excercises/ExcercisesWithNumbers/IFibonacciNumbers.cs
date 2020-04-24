using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.ExcercisesWithNumbers
{
    public interface IFibonacciNumbers
    {
        int GetFibonacciNumber(int num);
        IEnumerable<int> GetFibonacciNumbersUpTo(int num);
    }
}
