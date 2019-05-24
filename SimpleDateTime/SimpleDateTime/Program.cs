using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Current date and time: {0}",DateTime.Now);
            Console.WriteLine("Please enter a number");
            double addTime = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The date and time in {0} hours will be, {1}.",addTime,DateTime.Now.AddHours(addTime));
            Console.ReadLine();

        }
    }
}
