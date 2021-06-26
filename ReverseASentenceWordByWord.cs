using System;
using System.Collections.Generic;
using System.Text;

namespace ParehthesisCheck
{
    class ReverseASentenceWordByWord
    {
        public static string ReverseSentenceWordByWordMethod(string input)
        {
            string[] words = input.Split(' ');
            string reverse = "";

            foreach (string str in words)
            {
                for (int i = str.Length - 1; i >= 0; i--)
                {
                    reverse += str[i];
                }

                reverse += " ";
            }

            return reverse;
        }
    }
}
