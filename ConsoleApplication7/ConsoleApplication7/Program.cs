using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<Double, Double> Cpointer = x => 3.14*x*x;
            double area = Cpointer(20);
            Action<String> myString = y => Console.WriteLine(y);
            myString("Hello World!");
            Console.ReadKey();


        }
    }
}
