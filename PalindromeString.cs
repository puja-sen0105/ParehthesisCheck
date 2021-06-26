using System;
using System.Collections.Generic;
using System.Text;

namespace ParehthesisCheck
{
   public static class PalindromeString
    {
        public static Boolean isPalindrome(this string str)
        {
            Boolean flag = true;
            for (int i = 0, j = str.Length -1; i < j; i++,j--){
                if (str[i] != str[j])
                {
                    flag = false;
                    break;
                }
            }

            return flag;
        }
    }

}
