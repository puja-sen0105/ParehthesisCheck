using System;
using System.Collections.Generic;
using System.Text;

namespace ParehthesisCheck
{
    class factorial
    {
        public static int factorialRecursive(int x)
        {
            if (x <= 1)
            {
                return 1;
            }
            else
            {
                return x * factorialRecursive(x - 1);
            }
        }

        public static int factorialIterative(int x)
        {
            int factorial = 1;
            for (int i = 1; i <= x; i++)
            {
                factorial = factorial * i;
            }

            return factorial;
        }
    }
}
