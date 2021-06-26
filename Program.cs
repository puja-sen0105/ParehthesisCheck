using System;

namespace ParehthesisCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "abc";
            //var fa = str.isPalindrome();

            //string sent = ReverseASentence.ReverseSentenceMethod("I am puja");

           // string str = "[{c*(a+b)}/d]";
            string str = "[{c*(a+b}/d]";
            Boolean val = ParenthesisProgram.IsEqual(str);

            Console.WriteLine("Hello World!");
        }
    }
}
