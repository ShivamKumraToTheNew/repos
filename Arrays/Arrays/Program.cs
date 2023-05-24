using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] cars = { "Volvo", "BMW", "Ford" };
            Console.WriteLine(cars[0]);
            Console.ReadLine();
            Console.WriteLine(cars.Length); 
            Console.ReadLine();
            //Arrays sorting
            Array.Sort(cars);
            foreach(string i in cars) {
                Console.WriteLine(i);
                Console.ReadLine();
            }
        }
    }
}
