namespace FizzBuzz.Library
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    public class NumberChecker
    {
        public List<string> Output()
        {
            var seq = Enumerable.Range(1, 100);
            var result = ProcessRange(seq, "Fizz", "Buzz", "FizzBuzz");

            return result;
        }

        public List<string> Output(int rangeStart, int rangeEnd)
        {

            if (rangeStart >= rangeEnd)
            {
                throw new InvalidParameterException("The rangeStart must be less than the rangeEnd");
            }

            var seq = Enumerable.Range(rangeStart, rangeEnd);
            var result = ProcessRange(seq, "Fizz", "Buzz", "FizzBuzz");

            return result;
        }

        public List<string> Output(string tokenFor3, string tokenFor5, string tokenForBoth)
        {
            string parameterValidationErrorMessage = string.Empty;

            if(tokenFor3 == null){
                parameterValidationErrorMessage = string.Format("TokenFor3 must not be null.{0}", Environment.NewLine);
            }

            if (tokenFor5 == null)
            {
                parameterValidationErrorMessage += string.Format("TokenFor5 must not be null.{0}", Environment.NewLine);
            }

            if (tokenForBoth == null)
            {
                parameterValidationErrorMessage += string.Format("TokenForBoth must not be null.{0}", Environment.NewLine);
            }

            if (parameterValidationErrorMessage.Length > 0)
            {
                throw new InvalidParameterException(parameterValidationErrorMessage);
            }

            var seq = Enumerable.Range(1, 100);
            var result = ProcessRange(seq, tokenFor3, tokenFor5, tokenForBoth);

            return result;
        }

        public List<string> Output(int rangeStart, int rangeEnd, string tokenFor3, string tokenFor5, string tokenForBoth)
        {
            string parameterValidationErrorMessage = string.Empty;

            if (tokenFor3 == null)
            {
                parameterValidationErrorMessage = string.Format("TokenFor3 must not be null.{0}", Environment.NewLine);
            }

            if (tokenFor5 == null)
            {
                parameterValidationErrorMessage += string.Format("TokenFor5 must not be null.{0}", Environment.NewLine);
            }

            if (tokenForBoth == null)
            {
                parameterValidationErrorMessage += string.Format("TokenForBoth must not be null.{0}", Environment.NewLine);
            }

            if (rangeStart >= rangeEnd)
            {
                parameterValidationErrorMessage += string.Format("The rangeStart must be less than the rangeEnd.{0}", Environment.NewLine);
            }

            if (parameterValidationErrorMessage.Length > 0)
            {
                throw new InvalidParameterException(parameterValidationErrorMessage);
            }

            var seq = Enumerable.Range(rangeStart, rangeEnd);
            var result = ProcessRange(seq, tokenFor3, tokenFor5, tokenForBoth);

            return result;
        }

        private static List<string> ProcessRange(IEnumerable<int> seq, string tokenFor3, string tokenFor5, string tokenForBoth)
        {
            string screenOutput = string.Empty;
            List<string> result = new List<string>();

            foreach (int item in seq)
            {
                screenOutput = string.Empty;

                int remainder3 = item % 3;
                if (remainder3 == 0)
                {
                    screenOutput = tokenFor3;
                }

                int remainder5 = item % 5;
                if (remainder5 == 0)
                {
                    screenOutput = tokenFor5;
                }

                if (remainder3 == 0 && remainder5 == 0)
                {
                    screenOutput = tokenForBoth;
                }

                if (screenOutput.Length == 0)
                {
                    result.Add(item.ToString());
                }
                else
                {
                    result.Add(screenOutput);
                }
            }
            return result;
        }
    }
}
