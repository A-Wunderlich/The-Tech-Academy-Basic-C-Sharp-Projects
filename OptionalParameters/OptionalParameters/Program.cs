using System;

namespace OptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods m = new Methods();
            Console.WriteLine("Please enter a number to used in mathmatic operation.");
            int numOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a second number to used in mathmatic the operation.(You do not have to enter a number here)");
            string numTwoStr = Console.ReadLine();
            if (numTwoStr == "")
            {
                int test = m.Math(numOne);
                Console.WriteLine("The result is: {0}", test);
            }
            else
            {
                int numTwo = Convert.ToInt32(numTwoStr);
                int test = m.Math(numOne,numTwo);
                Console.WriteLine("The result is: {0}", test);
            }
        }

    }
}
