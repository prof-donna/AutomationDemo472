using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationDemo472
{
    public class LocationTranslator
    {
        // NOTE: this is a private instance of the INTERFACE of a parser object, so that...
        private ILocationParser _parser;

        // (a) you can use a REAL instance of the parser object, which extends the interface... OR
        public LocationTranslator()
        {
            // _parser = new LocationParser();
        }

        // (b) you can use MOCKED version of the parser object for testing purposes
        public LocationTranslator(ILocationParser parser)
        {
            _parser = parser;
        }


        public string LocationInFrench(string input)
        {
            string result = "";

            if (_parser.LocationIsCanada(input))
            {
                result = "Canada";
            }
            else if (_parser.LocationIsUSA(input))
            {
                result = "États-Unis d'Amérique";
            }
            else
            {
                result = input; // if not handled, return the original
            }

            return result;
        }


        public string LocationInGerman(string input)
        {
            string result = "";

            if (_parser.LocationIsCanada(input))
            {
                result = "Kanada";
            }
            else if (_parser.LocationIsUSA(input))
            {
                result = "Vereinigten Staaten von Amerika";
            }
            else
            {
                result = input; // if not handled, return the original
            }

            return result;
        }
    }
}
