using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excercises;
using Excercises.ExcercisesWithNumbers;

namespace Excercises.Test
{
    [TestFixture]
    class FibonacciNumbersTest
    {
        IFibonacciNumbers _fibonacci;

        [SetUp]
        public void SetUp()
        {
            _fibonacci = new FibonacciNumbers();
        }

        // GetFibonacciNumber() test cases
        [Test]
        [TestCase(-1)]
        [TestCase(-100)]
        [TestCase(-10000)]
        public void GetFibonacciNumber_CallingWhithNegativeNumber_ThrowArgumentIsNegativeException(int num)
        {
            Assert.Throws<ArgumentIsNegativeException>(() => _fibonacci.GetFibonacciNumber(num));
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(5, 5)]
        [TestCase(10, 55)]
        [TestCase(20, 6765)]
        public void GetFibonacciNumber_CallingWithPositiveNumbers_ReturnTheFibonacciNumber(int num, int expectidResult)
        {
            int result = _fibonacci.GetFibonacciNumber(num);

            Assert.That(result, Is.EqualTo(expectidResult));
        }

        // GetFibonacciNumbersUpTo() test cases
        [Test]
        [TestCase(-1)]
        [TestCase(-10)]
        [TestCase(-10000)]
        public void GetFibonacciNumbersUpTo_CallingWhithNegativeNumber_ThrowArgumentIsNegativeException(int num)
        {
            Assert.Throws<ArgumentIsNegativeException>(() => _fibonacci.GetFibonacciNumbersUpTo(num));
        }

        [Test]
        [TestCase(0, new int[] { 0 })]
        [TestCase(1, new int[] { 0, 1 })]
        [TestCase(5, new int[] { 0, 1, 1, 2, 3, 5 })]
        [TestCase(10, new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55})]
        public void GetFibonacciNumbersUpTo_CallingWithPositiveNumbers_ReturnTheListOfNumbers(int num, int[] expectedResultArr)
        {
            IEnumerable<int> result = _fibonacci.GetFibonacciNumbersUpTo(num);

            IEnumerable<int> expectedResult = expectedResultArr.ToList();
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
