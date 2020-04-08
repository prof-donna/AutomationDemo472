using NUnit.Framework;
using AutomationDemo472;

namespace AutomationDemo472Tests
{
    public class ResponseParserUnitTests
    {
        [Test]
        public void IsParseable_ZeroLengthInput_ReturnsFalse()
        {
            // arrange
            string input = "";
            bool expected = false;

            // act
            ResponseParser sut = new ResponseParser();
            bool actual = sut.IsParseable(input);

            // assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void IsParseable_OneLengthInput_ReturnsTrue()
        {
            // arrange
            string input = "a";
            bool expected = true;

            // act
            ResponseParser sut = new ResponseParser();
            bool actual = sut.IsParseable(input);

            // assert
            Assert.AreEqual(expected, actual);

        }


        [Test]
        public void IsParseable_OneSpaceInput_ReturnsFalse()
        {
            // arrange
            string input = " ";
            bool expected = false;

            // act
            ResponseParser sut = new ResponseParser();
            bool actual = sut.IsParseable(input);

            // assert
            Assert.AreEqual(expected, actual);

        }


        [Test]
        public void IsAffirmative_NotAffirmative_ReturnsFalse()
        {
            // arrange
            string input = "Hello";
            bool expected = false;

            // act
            ResponseParser sut = new ResponseParser();
            bool actual = sut.IsAffirmative(input);

            // assert
            Assert.AreEqual(expected, actual);

        }

        [TestCase("Yes")]
        [TestCase("YES")]
        [TestCase("yes")]
        [TestCase("yes ")]
        public void IsAffirmative_YesValue_ReturnsTrue(string input)
        {
            // arrange
            bool expected = true;

            // act
            ResponseParser sut = new ResponseParser();
            bool actual = sut.IsAffirmative(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("True")]
        [TestCase("TRUE")]
        [TestCase("true")]
        [TestCase("true ")]
        public void IsAffirmative_TrueValue_ReturnsTrue(string input)
        {
            // arrange
            bool expected = true;

            // act
            ResponseParser sut = new ResponseParser();
            bool actual = sut.IsAffirmative(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("Y")]
        [TestCase("y")]
        [TestCase("y ")]
        public void IsAffirmative_YValue_ReturnsTrue(string input)
        {
            // arrange
            bool expected = true;

            // act
            ResponseParser sut = new ResponseParser();
            bool actual = sut.IsAffirmative(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("T")]
        [TestCase("t")]
        [TestCase("t ")]
        public void IsAffirmative_TValue_ReturnsTrue(string input)
        {
            // arrange
            bool expected = true;

            // act
            ResponseParser sut = new ResponseParser();
            bool actual = sut.IsAffirmative(input);

            // assert
            Assert.AreEqual(expected, actual);
        }



        [Test]
        public void IsNegative_NotNegative_ReturnsFalse()
        {
            // arrange
            string input = "Hello";
            bool expected = false;

            // act
            ResponseParser sut = new ResponseParser();
            bool actual = sut.IsNegative(input);

            // assert
            Assert.AreEqual(expected, actual);

        }

        [TestCase("No")]
        [TestCase("NO")]
        [TestCase("no")]
        [TestCase("no ")]
        public void IsNegative_NoValue_ReturnsTrue(string input)
        {
            // arrange
            bool expected = true;

            // act
            ResponseParser sut = new ResponseParser();
            bool actual = sut.IsNegative(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("False")]
        [TestCase("FALSE")]
        [TestCase("false")]
        [TestCase("false ")]
        public void IsNegative_FalseValue_ReturnsTrue(string input)
        {
            // arrange
            bool expected = true;

            // act
            ResponseParser sut = new ResponseParser();
            bool actual = sut.IsNegative(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("N")]
        [TestCase("n")]
        [TestCase("n ")]
        public void IsNegative_NValue_ReturnsTrue(string input)
        {
            // arrange
            bool expected = true;

            // act
            ResponseParser sut = new ResponseParser();
            bool actual = sut.IsNegative(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("F")]
        [TestCase("f")]
        [TestCase("f ")]
        public void IsNegative_FValue_ReturnsTrue(string input)
        {
            // arrange
            bool expected = true;

            // act
            ResponseParser sut = new ResponseParser();
            bool actual = sut.IsNegative(input);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}