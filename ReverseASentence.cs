using System;
using System.Collections.Generic;
using System.Text;

namespace ParehthesisCheck
{
    class ReverseASentence
    {
        public static string ReverseSentenceMethod(string input)
        {
            string[] words = input.Split(' ');
            string reverse = "";

            for (int i = words.Length - 1; i >= 0; i--)
            {
                string word = words[i];
                for (int j = word.Length - 1; j >= 0; j--)
                {
                    reverse += word[j];
                }

                reverse += " ";
            }

            return reverse;
        }
    }
}
