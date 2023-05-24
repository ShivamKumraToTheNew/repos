using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool b=true;
            Console.WriteLine("Is C sharp fun: " + b);
            Console.ReadLine();

            //equalto in boolean
            Console.WriteLine("Is 10 equal to 9");
            Console.WriteLine(10==9);
            Console.ReadLine();

            //Logical operators
            Console.WriteLine("Is 5<9 and 7>8");
            Console.WriteLine(5<9 && 7>8);
            Console.ReadLine();
            Console.WriteLine("Is 5 not lower than 9");
            Console.WriteLine(!(5<9));
            Console.ReadLine();
        }
    }
}
