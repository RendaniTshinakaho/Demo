using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareIt
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = 10;
            SquareIt(x);
        }
        public static void SquareIt(int x)
        {
            x = x*x;
            Console.WriteLine(x.ToString());
            Console.ReadLine();
        }
    }
}
