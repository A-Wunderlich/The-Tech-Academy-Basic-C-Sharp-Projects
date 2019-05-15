using System;
using System.Collections.Generic;
using System.Text;

namespace MethodOutputs
{
    public class Method
    {
        public void Divide(int number, out int div)
        {
            div = number / 2;
        }
        public void Addition(out int p, out int q)
        {
            p = 30;
            q = 40;
            p += p;
            q += q;
        }

        public void Addition(out decimal p, out decimal q)
        {
            p = 12.25m;
            q = 16.33m;
            p += p;
            q += q;
        }

    }

}
