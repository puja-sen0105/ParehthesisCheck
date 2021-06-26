using System;
using System.Collections.Generic;
using System.Text;

namespace ParehthesisCheck
{
    class ReverseAString
    {
        public static string ReverseInBuilt(string str)
        {
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        public static string ReverseMethod(string str)
        {
           
            string reverse = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverse += str[i];
            }

            return reverse;
        }

        public static string ReverseUsingWhile(string stringInput)
        {
           
            string reversestring = "";
            int length;

            length = stringInput.Length - 1;

            while (length >= 0)
            {
                reversestring = reversestring + stringInput[length];
                length--;
            }

            return reversestring;

        }
    }
}
