using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Number dec = new Number();
            dec.Amount = 5.55m;
            Console.WriteLine(dec.Amount);
            Console.ReadLine();
        }
        public struct Number
        {
            public decimal Amount { get; set; }
        }
    }
}
