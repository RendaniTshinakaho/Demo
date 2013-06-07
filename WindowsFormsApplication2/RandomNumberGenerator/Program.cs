using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<Double, Double> Cpointer = r => 3.14*r*r;
            Double area = Cpointer (20);
            
           Action<string> myAction = y => Console.WriteLine(y);
            myAction("Hello World");
            Console.ReadLine();
            
            var k = new Random(553);
            //Print random intger
            Console.WriteLine(k.Next());
            Console.ReadLine();
        }
    }
}
