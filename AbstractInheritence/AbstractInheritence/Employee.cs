using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractInheritence
{
    class Employee : Person
    {
        public int Id { get; set; }
        public override void SayName()
        {
            base.SayName();
        }

        public static Boolean operator==(Employee employee1, Employee employee2)
        {
            if (employee1.Id == employee2.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
        public static Boolean operator !=(Employee employee1, Employee employee2)
        {
            if (employee1.Id != employee2.Id)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
