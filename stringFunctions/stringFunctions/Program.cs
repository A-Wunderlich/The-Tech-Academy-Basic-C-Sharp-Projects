using System;
using System.Text;

namespace stringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string pt1 = "Happy";
            string pt2 = " birthday ";
            string pt3 = "to you!\n";
            Console.WriteLine(pt1 + pt2 + pt3);
            string says = "I'm not yelling!\n";
            Console.WriteLine(says.ToUpper());
            StringBuilder poem = new StringBuilder();
            poem.Append("Tell me not, in mournful numbers,\n");
            poem.Append("Life is but an empty dream!—\n");
            poem.Append("For the soul is dead that slumbers,\n");
            poem.Append("And things are not what they seem.");
            Console.WriteLine(poem);
            Console.Read();

        }
    }
}
