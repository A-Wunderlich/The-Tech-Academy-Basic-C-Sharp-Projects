using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to be logged.");
            string num = Console.ReadLine();
            File.WriteAllText(@"numLog.txt", num);
            string numRead = File.ReadAllText(@"numLog.txt");
            Console.WriteLine("Your number {0} was added to the log:\n{1}",num,numRead);
            Console.ReadLine();
        }
    }
}
