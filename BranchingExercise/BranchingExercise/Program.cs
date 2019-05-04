using System;

namespace BranchingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight: ");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight >= 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.Read();
            }
            else
            {
                Console.WriteLine("Please enter the package width: ");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package height: ");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package length: ");
                int length = Convert.ToInt32(Console.ReadLine());
                int sum = width + length + height;
                if (sum > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                    Console.Read();
                }
                else
                {
                    decimal total = (sum * weight) / 100.00m + 0.00m;
                    Console.WriteLine("Your estimated total for shipping this package is: $" + total+"\nThank You!");
                    Console.Read();
                }
            }
        }
    }
}
