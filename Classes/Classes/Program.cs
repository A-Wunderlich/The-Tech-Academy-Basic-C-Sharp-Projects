using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number do you want to do the math operations on?");
            int num = Convert.ToInt32(Console.ReadLine());
            int pro = Operation.Mult2(num);
            Console.WriteLine("Multiplied by 2 the product is: " + pro);
            int sum = Operation.Add100(num);
            Console.WriteLine("With 100 added to it the sum is: " + sum);
            int sumPro = Operation.MultAdd(num);
            Console.WriteLine("Your number added to 100 THEN multiplied by 2 is: " + sumPro + "!");
            Console.ReadLine();
        }
    }
}
