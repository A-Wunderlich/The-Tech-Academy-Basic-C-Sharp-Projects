using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class Employee<T> : Person, IQuittable
    {
        public List<T> Things = new List<T> { };
        public override void SayName()
        {
            base.SayName();
        }
        public void Quit()
        {
            Console.WriteLine("THEY QUIT!!! Quiter...");
        }
    }
}
