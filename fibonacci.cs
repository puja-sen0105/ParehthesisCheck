using System;
using System.Collections.Generic;
using System.Text;

namespace ParehthesisCheck
{
    // 1 1 2 3 5 8
    class fibonacci
    {
        public static int FibRecursive(int x)
        {
            if (x <= 1)
            {
                return x;
            }
            else
            {
                return FibRecursive(x - 1) + FibRecursive(x - 2);
            }
        }

        public static int FibIterative(int x)
        {
            int firstNumber = 0;
            int secondNumber = 1;
            int result = 0;

            for(int i = 3; i <= x; i++)
            {
                result = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = result;
            }

            return result;
        }
    }
}
