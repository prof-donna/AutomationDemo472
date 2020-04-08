using System;

namespace AutomationDemo472
{
    public class ResponseParser
    {
        public enum Response
        { 
            Affirmative,
            Negative,
            Invalid
        }

        public Response ParseAnswer(string answer)
        {
            if (IsParseable(answer))
            {
                if (IsAffirmative(answer))
                    return Response.Affirmative;

                if (IsNegative(answer))
                    return Response.Negative;
            }

            return Response.Invalid;
        }

        public bool IsAffirmative(string input)
        {
            string cleaned_input = input.ToLower().Trim();

            if (cleaned_input.Equals("yes")
                || cleaned_input.Equals("true")
                || cleaned_input.Equals("y")
                || cleaned_input.Equals("t"))
                return true;

            return false;
        }

        public bool IsNegative(string input)
        {
            string cleaned_input = input.ToLower().Trim();

            if (cleaned_input.Equals("no")
                || cleaned_input.Equals("false")
                || cleaned_input.Equals("n")
                || cleaned_input.Equals("f"))
                return true;

            return false;
        }


        public bool IsParseable(string input)
        {
            // RULE: input string needs to be at least 1 character in length

            if (input.Trim().Length < 1)
                return false;

            return true;
        }
    }
}
