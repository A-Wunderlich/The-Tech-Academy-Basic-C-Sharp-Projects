using System;
using System.Collections.Generic;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            //employee.SayName();
            //IQuittable employeeQuit = new Employee();
            //employeeQuit.Quit();
            //Console.ReadLine();

            Employee<string> employee = new Employee<string>() { Things = { "One", "Two", "Three","Four" } };
            Employee<int> employee2 = new Employee<int>() { Things = { 1, 2, 3, 4 } };
            foreach (string thing in employee.Things)
            {
                Console.WriteLine(thing);
            }
            foreach(int thing in employee2.Things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();


        }
    }
}
