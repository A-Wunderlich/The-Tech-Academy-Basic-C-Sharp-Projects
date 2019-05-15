using System;

namespace MethodOutputs
{
    class Program
    {
        static void Main(string[] args)
        {
            Method m = new Method();
            Console.WriteLine("Please choose a number to be divided.");
            int number = Convert.ToInt32(Console.ReadLine());
            int div;
            m.Divide(number,out div);
            Console.WriteLine("After method call, the value is : {0}", div);
            int a, b;
            m.Addition(out a, out b);
            Console.WriteLine("The addition of the value is: {0}", a);
            Console.WriteLine("The addition of the value is: {0}", b);
            decimal c, d;
            m.Addition(out c, out d);
            Console.WriteLine("The addition of the value is: {0}", c);
            Console.WriteLine("The addition of the value is: {0}", d);
        }
    }
}
