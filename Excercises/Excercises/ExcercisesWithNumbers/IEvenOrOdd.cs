using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.ExcercisesWithNumbers
{
    public interface IEvenOrOdd
    {
        bool IsEven(int number);
        bool IsOdd(int number);
        IEnumerable<int> AllPositiveEvenNumsUnderTheGivenNumber(int number);
    }
}
