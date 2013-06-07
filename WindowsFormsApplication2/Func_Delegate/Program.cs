using System;

namespace Func_Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            //You can inputs as well as outputs.
            Func<Double, Double> Cpointer = r => 3.12*r*r;
            double Area = Cpointer(20);
            //Does not return a value.
            Action<string> MyAction = y => Console.WriteLine(y);
            MyAction("Hello World");
            Console.ReadKey();

            //will always returns an input of boolean
            Predicate<string> CheckGreaterThan5 = x => x.Length > 5;            
            Console.WriteLine(CheckGreaterThan5("Rend12356")); 
            Console.ReadKey();

        }
    }
}
