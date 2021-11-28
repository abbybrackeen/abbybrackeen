using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCodeSample.Algorithms
{
    public class ReverseString
    {
        public class StringReverseResult
        {
            //public string reversedString { get; set; }
            public bool isSuccessful { get; set; }
            public string Message { get; set; }
        }

        //easiest solution
        public string ReverseStringFunc(string stringInput)
        {
            var result = ValidateAndReverse(stringInput);
            return result.Message;
                    }

        public StringReverseResult ValidateAndReverse(string stringInput)
        {
            var result = new StringReverseResult();
            var instructions = "Your text must be at least 2 characters long & cannot be just whitespace.";

            if (string.IsNullOrWhiteSpace(stringInput))
            {
                result.isSuccessful = false;
                result.Message = $"You didn't enter anything! {instructions}";
            }
            else if (stringInput.Length < 2)
            {
                result.isSuccessful = false;
                result.Message = $"You only put in one number! {instructions}";
            }
            else
            {
                //convert to array & reverse
                char[] charArray = stringInput.ToCharArray();
                Array.Reverse(charArray);

                //convert to string and assign
               string reversedString = new string(charArray);
                result.isSuccessful = true;
                result.Message = $"Here is your reversed text: {reversedString}";
            }

            return result;
        }

    }
}
