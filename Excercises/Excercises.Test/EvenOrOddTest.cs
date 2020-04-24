using System;
using NUnit.Framework;
using Excercises;
using Excercises.ExcercisesWithNumbers;
using System.Collections.Generic;

namespace Excercises.Test
{
	[TestFixture]
    public class EvenOrOddTest
    {
        IEvenOrOdd _evenOrOdd;

		[SetUp]
		public void SetUp()
        {
            _evenOrOdd = new EvenOrOdd();
        }

		// IsEven() test cases
		[Test]
		public void IsEven_TheGivenNumberIsEven_ReturTrue()
        {
            bool result = _evenOrOdd.IsEven(2);

            Assert.That(result, Is.True);
        }

		[Test]
		public void IsEven_TheGivenNumberIsOdd_ReturnFalse()
        {
            bool result = _evenOrOdd.IsEven(1);

            Assert.That(result, Is.False);
        }

		// IsOdd() test cases
		[Test]
		public void IsOdd_TheGivenNumberIsOdd_ReturnTrue()
        {
            bool result = _evenOrOdd.IsOdd(1);

            Assert.That(result, Is.True);
        }

		[Test]
		public void IsOdd_TheGivenNumberIsEven_ReturnFalse()
        {
            bool result = _evenOrOdd.IsOdd(2);

            Assert.That(result, Is.False);
        }

        // AllPositiveEvenNumsUnderTheGivenNumber() test cases
        [Test]
		public void AllPositiveEvenNumsUnderTheGivenNumber_TheArgumentIsZero_ThrowArgumentIsZeroException()
        {
            Assert.Throws<ArgumentIsZeroException>(() => _evenOrOdd.AllPositiveEvenNumsUnderTheGivenNumber(0));
        }

		[Test]
		[TestCase(-1)]
		[TestCase(-100)]
		[TestCase(-100000)]
		public void AllPositiveEvenNumsUnderTheGivenNumber_TheArgumentIsNegative_ThrowArgumentIsNegativeException(int num)
        {
            Assert.Throws<ArgumentIsNegativeException>(() => _evenOrOdd.AllPositiveEvenNumsUnderTheGivenNumber(num));
        }

		[Test]
		public void AllPositiveEvenNumsUnderTheGivenNumber_TheNumberIs8_ReturnTheListOfNumber()
        {
            IEnumerable<int> results = _evenOrOdd.AllPositiveEvenNumsUnderTheGivenNumber(6);

            int[] expectedNums = {0, 2, 4, 6};
            IEnumerable<int> expectedResult = new List<int>(expectedNums);
            Assert.That(results, Is.EqualTo(expectedResult));
        }
    }
}
