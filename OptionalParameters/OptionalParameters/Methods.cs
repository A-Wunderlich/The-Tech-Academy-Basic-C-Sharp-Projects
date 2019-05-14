using System;
using System.Collections.Generic;
using System.Text;

namespace OptionalParameters
{
    public class Methods
    {
        public int Math(int numOne, int numTwo = 2)
        {
            return (numOne + 12) * (numTwo + 15);
        }
    }
}
