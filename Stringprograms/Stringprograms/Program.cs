using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringprograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String str1 = "Hello";
            Console.WriteLine(str1.Length);
            Console.ReadLine();
            //concating two strings
            String str2 = "World";
            string str3 =str1 + str2;
            string str4= string.Concat(str1, str2);
            Console.WriteLine(str4);
            Console.WriteLine(str3);
            Console.ReadLine();
        }
    }
}
