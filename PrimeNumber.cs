using System;
using System.Collections.Generic;
using System.Text;

namespace ParehthesisCheck
{
    class PrimeNumber
    {
        public static Boolean isPrimeNumber(int num)
        {
            Boolean flag = true;
            if (num == 1) { return false; }
            if (num % 2 == 0) { return false; }
            for(int i = 3; i < num / 2; i += 2)
            {
                if (num % i == 0)  
                {
                    flag = false; 
                }
            }

            return flag;
        }
    }
}
