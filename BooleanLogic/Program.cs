using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI?");
            bool dui = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qualified?");
            Console.WriteLine((age > 15) && (tickets <= 3) && (dui == false));
            Console.Read();


        }
    }
}
