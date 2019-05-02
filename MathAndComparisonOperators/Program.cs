using System;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to be multiplied by 50");
            string multi50 = Console.ReadLine();
            int num50 = Convert.ToInt32(multi50);
            Console.WriteLine("The total is: " + (num50 * 50)+ "\n");
            Console.WriteLine("Enter a number to be added to 25");
            string add25 = Console.ReadLine();
            int num25 = Convert.ToInt32(add25);
            Console.WriteLine("The total is: " + (num25 + 25) + "\n");
            Console.WriteLine("Enter a number to be divided by 12.5");
            string div125 = Console.ReadLine();
            int num125 = Convert.ToInt32(div125);
            float numdiv = (num125 / 12.5f);
            Console.WriteLine("The total is: " + numdiv + "\n");
            Console.WriteLine("Enter a number to see if it is greater than 50");
            string test50 = Console.ReadLine();
            int numt50 = Convert.ToInt32(test50);
            bool testResult = (numt50 > 50);
            Console.WriteLine("Is " + numt50 + " greater than 50?: " + testResult+ "\n");
            Console.WriteLine("Enter a numnber to find the remander when divided by 7");
            string remInput = Console.ReadLine();
            int remainder = (Convert.ToInt32(remInput) % 7);
            Console.WriteLine("The remainder of " + remInput + " when divided by 7 is: " + remainder);
            Console.Read();





        }
    }
}
