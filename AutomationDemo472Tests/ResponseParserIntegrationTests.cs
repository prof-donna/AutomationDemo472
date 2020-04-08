using NUnit.Framework;
using AutomationDemo472;

namespace AutomationDemo472Tests
{
    public class ResponseParserIntegrationTests
    {

        [Test]
        public void ParseAnswer_UnparseableAnswer_InvalidResponse()
        {
            // arrange
            string answer = "    ";
            ResponseParser.Response expected = ResponseParser.Response.Invalid;

            // act
            ResponseParser sut = new ResponseParser();
            ResponseParser.Response actual = sut.ParseAnswer(answer);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ParseAnswer_InvalidAnswer_InvalidResponse()
        {
            // arrange
            string answer = "Hello";
            ResponseParser.Response expected = ResponseParser.Response.Invalid;

            // act
            ResponseParser sut = new ResponseParser();
            ResponseParser.Response actual = sut.ParseAnswer(answer);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ParseAnswer_YesAnswer_AffirmativeResponse()
        {
            // arrange
            string answer = "Yes";
            ResponseParser.Response expected = ResponseParser.Response.Affirmative;

            // act
            ResponseParser sut = new ResponseParser();
            ResponseParser.Response actual = sut.ParseAnswer(answer);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ParseAnswer_NoAnswer_NegativeResponse()
        {
            // arrange
            string answer = "No";
            ResponseParser.Response expected = ResponseParser.Response.Negative;

            // act
            ResponseParser sut = new ResponseParser();
            ResponseParser.Response actual = sut.ParseAnswer(answer);

            // assert
            Assert.AreEqual(expected, actual);
        }

    }
}
