using System;

namespace Loops1
{
    class Program
    {
        static void Main(string[] args)
        {
            //this counts by 1 from 0 all the numbers less than 10
            int z = 0;
            while (z < 10)
            {
                Console.WriteLine(z);
                z++;
            }
            //this counts by 1 all the numbers less than 10, since x already is 10 without the 'do' this wouldn't print anything
            int x = 10;
            do
            {
                Console.WriteLine(x);
                x++;
            }
            while (x < 10);
            Console.Read();
        }
    }
}
