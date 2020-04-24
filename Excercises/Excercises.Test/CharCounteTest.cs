using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Excercises;

namespace Excercises.Test
{
    [TestFixture]
    public class CharCounteTest
    {
        ICharCounter _counter;

        [SetUp]
        public void SetUp()
        {
            _counter = new CharCounter();
        }

        // GivenCharacterCounter() test caces

        [Test]
        public void GivenCharacterCounter_ContainsTheCharacter_ReturnTheNumsOfCharacter()
        {
            int result = _counter.GivenCharacterCounter('a', "malac");

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void GivenCharacterCounter_DoesNotContainsTheCharacter_ReturnZero()
        {
            int result = _counter.GivenCharacterCounter('i', "malac");

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void GivenCharacterCounter_StringIsNullOrEmpty_ThrowArgumentNullException()
        {
            Assert.That(() => _counter.GivenCharacterCounter('i', ""), Throws.ArgumentNullException);
            Assert.That(() => _counter.GivenCharacterCounter('i', " "), Throws.ArgumentNullException);
            Assert.That(() => _counter.GivenCharacterCounter('i', null), Throws.ArgumentNullException);
        }

        //  CharacterCounter() test cases

        [Test]
        public void CharacterCounter_StringIsNullOrEmpty_ArgumentNullException()
        {
            Assert.That(() => _counter.CharacterCounter(""), Throws.ArgumentNullException);
            Assert.That(() => _counter.CharacterCounter(" "), Throws.ArgumentNullException);
            Assert.That(() => _counter.CharacterCounter(null), Throws.ArgumentNullException);
        }

        [Test]
        public void CharacterCounter_WhenCalledWithAWord_ReturnCharactarString()
        {
            string result = _counter.CharacterCounter("potato");

            Assert.That(result, Is.EqualTo("a1o2p1t2"));
        }

        [Test]
        public void CharacterCounter_WhenCalledWithMoreSameCharacter_ReturnCharacterString()
        {
            string result = _counter.CharacterCounter("aaaa");

            Assert.That(result, Is.EqualTo("a4"));
        }

        [Test]
        public void CharacterCounter_WhenCalledWithACentence_ReturnCharacterString()
        {
            string result = _counter.CharacterCounter("Hello World!");

            Assert.That(result, Is.EqualTo("d1e1h1l3o2w1"));
        }

    }
}
