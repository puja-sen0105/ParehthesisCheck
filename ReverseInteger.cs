using System;
using System.Collections.Generic;
using System.Text;

namespace ParehthesisCheck
{
    class ReverseInteger
    {
        public int ReverseMethod(int x)
        {
            int reverse = 0;
            int rem = 0;

            while (x <= 0)
            {
                rem = x % 10;
                reverse = reverse * 10 + rem;
                x = x / 10;
            }

            return reverse;
        }
    }
}
