using System;
using System.Collections.Generic;
using System.Text;

namespace ParehthesisCheck
{
    class ParenthesisProgram
    {
        public static Boolean IsEqual(string str)
        {
            Stack<char> sta = new Stack<char>();
            
            Dictionary<char, char> dict = new Dictionary<char, char>();
            dict.Add('}', '{');
            dict.Add(']', '[');
            dict.Add(')', '(');

            List<char> lst = new List<char>();
            lst.Add('{');
            lst.Add('[');
            lst.Add('(');

            foreach (char ch in str)
            {
                if (lst.Contains(ch))
                {
                    sta.Push(ch);
                }
                else if (dict.ContainsKey(ch) && sta.Peek() == dict[ch])
                {
                    sta.Pop();
                }
            }

            if (sta.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
