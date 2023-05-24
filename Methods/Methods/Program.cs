using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void myMethod()
        {
            Console.WriteLine("method1 call");

        }
        /*
        static void Main(string[] args)
        {
            myMethod();
            Console.ReadLine();
        }
        */

        //method with parameters
        static void myMethod(string n1)
        {
            Console.WriteLine(n1);

        }
        /*
        static void Main(string[] args)
        {
            myMethod("Called");
            Console.ReadLine();
        }
        */
        //out keyword
        static int Add(int x,int y,out int multiply)
        {
            multiply= x*y;
            return x + y;


        }
        static void Main(string[] args)
        {
            int mul;
            Console.WriteLine(Add(5,10,out mul));
            Console.WriteLine(mul);
            Console.ReadLine();
        }

    }
}
