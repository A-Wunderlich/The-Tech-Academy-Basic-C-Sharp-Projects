using System;

namespace Overloads
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods multi = new Methods();
            Console.WriteLine(multi.timesX(12));
            Methods multi2 = new Methods();
            Console.WriteLine(multi2.timesX(12.5m));
            Methods multi3 = new Methods();
            Console.WriteLine(multi3.timesX("13"));
            
        }
    }
}
