using System;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<Double, Double> Cpointer = x => 3.14*x*x;
            double Area = Cpointer(20);
            //
            Action<string> myWord = x => Console.WriteLine(x);
            myWord("Hello World!");
            Console.ReadKey();

        }
    }
}
