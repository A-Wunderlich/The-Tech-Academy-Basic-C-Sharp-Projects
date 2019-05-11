using System;

namespace Overloads
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods multi = new Methods();
            int solutionOne = multi.timesX(12);
            Console.WriteLine(solutionOne);
            decimal solutionTwo = multi.timesX(5.5m);
            Console.WriteLine(solutionTwo);
            int solutionThree = multi.timesX("13");
            Console.WriteLine(solutionThree);
            
        }
    }
}
