using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class Employee : Person, IQuittable
    {
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
