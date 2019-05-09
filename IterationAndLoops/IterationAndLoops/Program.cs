using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] clothes = { "hat", "shirt", "pants", "shoes" };
        Console.WriteLine("What is your favorite color?");
        string color = Console.ReadLine();
        for (int i = 0; i < clothes.Length; i++)
        {
            Console.WriteLine(color + " " + clothes[i]);
        }
        //this is the infinite loop, it goes on forever because 0 is always less than 10
        //for (int z = 0; 0 < 10; z++)
        //{
        //    Console.WriteLine(color + " is the best color!");
        //}
        for (int z = 0; z < 10; z++)
        {
            Console.WriteLine(color + " is the best color!");
        }
        for (int y = 1; y <= 6; y++)
        {
            Console.WriteLine(y);
        }
        List<string> uniqueList = new List<string>() { "Mario", "Luigi", "Peach", "Daisy" };
        Console.WriteLine("To find the index of a string in the list please pick a name to search from the following: Mario, Luigi, Peach, Daisy");
        string pick = Console.ReadLine();
        int counter = 0;
        foreach (string element in uniqueList)
        {
            if (element == pick)
            {
                int index = uniqueList.IndexOf(element);
                Console.WriteLine("the index of that string is: " + index);
                break;
            }
            else if (element != pick)
            {
                counter++;
                if (counter == uniqueList.Count)
                {
                    Console.WriteLine("Sorry there are no matching strings in the list");
                }
            }
        }
        List<string> doubleList = new List<string>() { "same", "different", "same", "discrete" };
        List<int> matches = new List<int>() { };
        int count = 0;
        Console.WriteLine("To find the index of a string in the list please pick a name to search from the following: same, different, same, discrete");
        string select = Console.ReadLine();
        for (int k = 0; k < doubleList.Count; k++)
        {
            if (doubleList[k] == select)
            {
                Console.WriteLine("That string is on index: " + k);
            }
            else if (doubleList[k] != select)
            {
                count++;
                if (count == doubleList.Count)
                {
                    Console.WriteLine("Sorry there are no matching strings in the list");
                }

            }
        }
        List<string> newList = new List<string>() { "same", "different", "same", "discrete", "not-same", "same" };
        int cnt = 0;
        foreach (string item in newList)
        {
            if (cnt <= newList.IndexOf(item))
            {
                Console.WriteLine(item);
                cnt++;
            }
            else if (cnt > newList.IndexOf(item))
            {
                Console.WriteLine(item + " *duplicate");
            }

        }


    }
}


