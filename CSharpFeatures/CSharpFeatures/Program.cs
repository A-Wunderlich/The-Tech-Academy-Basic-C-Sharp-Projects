using System;
using System.Collections;
using System.Collections.Specialized;
namespace CSharpFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            const string name = "George" ;
            //name = "Georgie";
            //this will not work because it is a constant

            var caps = new StringDictionary()
            {
                ["Oregon"] = "Salem",
                ["Washington"] = "Olympia",
                ["California"] = "Sacramento"

            };
            foreach(DictionaryEntry de in caps)
            {
                Console.WriteLine(de.Value);
            }
            Employee employee = new Employee("Austin", 101);
            Employee employee2 = new Employee("James");
            Console.WriteLine("{0} {1}\n{2} {3}",employee.Name,employee.Id,employee2.Name,employee2.Id);
            Console.WriteLine(name + " is a curious one");
            Console.ReadLine();

        }
        
    }
}
