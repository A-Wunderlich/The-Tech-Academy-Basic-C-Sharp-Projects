using System;
using System.Collections.Generic;
using System.Text;

namespace Overloads
{
    public class Methods
    {
        public int timesX(int num)
        {
            return num * 5;
        }
        public decimal timesX(decimal num)
        {
            return num * 3;
        }

        public int timesX(string num)
        {
            int numInt = Convert.ToInt32(num);
            return numInt * 13;
        }

    }
}
