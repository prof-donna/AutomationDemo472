using NUnit.Framework;
using AutomationDemo472;
using Moq;      // NOTE: Must add NuGet "Moq" package AND add this using statement

namespace AutomationDemo472Tests
{
    public class LocationTranslatorUnitTests
    {
        [Test]
        public void LocationInGerman_CanadaBecomesKanada()
        {
            // arrange
            string input = "Canada";
            string expected = "Kanada";

            // arrange - mocking the LocationParser object
            var mockLocationParser = new Mock<ILocationParser>();

            // define the behaviours of our mock Parser for the method under test
            mockLocationParser.Setup(parser => parser.LocationIsCanada(It.IsAny<string>())).Returns(true);
            mockLocationParser.Setup(parser => parser.LocationIsUSA(It.IsAny<string>())).Returns(false);

            // act

            // LocationTranslator is REAL object that is under test, but Parser is mocked
            LocationTranslator sut = new LocationTranslator( mockLocationParser.Object );
            string actual = sut.LocationInGerman(input);

            // assert
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void LocationInGerman_MexicoStaysMexico()
        {
            // arrange
            string input = "Mexico";
            string expected = "Mexico";

            // arrange - mocking the LocationParser object
            var mockLocationParser = new Mock<ILocationParser>();

            // define the behaviours of our mock Parser for the method under test
            mockLocationParser.Setup(parser => parser.LocationIsCanada(It.IsAny<string>())).Returns(false);
            mockLocationParser.Setup(parser => parser.LocationIsUSA(It.IsAny<string>())).Returns(false);

            // act

            // LocationTranslator is REAL object that is under test, but Parser is mocked
            LocationTranslator sut = new LocationTranslator(mockLocationParser.Object);
            string actual = sut.LocationInGerman(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

    }
}
