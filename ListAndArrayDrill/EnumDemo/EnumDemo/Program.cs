using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Days = Enum.GetNames(typeof(DaysOfTHeWeek));
            int endOfArray = 0;
            Console.WriteLine("Enter a day of the week");
            string uDay = Console.ReadLine();
            try
            {
                foreach (string day in Days)
                {
                        if (uDay == day)
                        {
                            Console.WriteLine("The value for that day of the week is: {0:D}", Enum.Parse(typeof(DaysOfTHeWeek), day));

                        }
                        else
                        {
                            endOfArray++;
                        }

                }
                if (endOfArray >= Days.Length)
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week");
                throw;
            }
            Console.ReadLine();
        }
        public enum DaysOfTHeWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
