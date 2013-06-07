using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100;i++ )
            {
                for (int j = 1; j >= i; j++)
                {
                    Console.WriteLine(j);
                }
                Console.WriteLine(i.ToString());
            }
            Console.ReadLine();
        }
    }
}
