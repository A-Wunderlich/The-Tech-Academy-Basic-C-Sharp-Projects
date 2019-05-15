using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractInheritence
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual void SayName()
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }
    }
}
