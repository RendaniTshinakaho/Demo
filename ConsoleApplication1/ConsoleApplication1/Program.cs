using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
           localhost.Service1 s1 = new ConsoleApplication1.localhost.Service1();
            string result = s1.HelloWorld();
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
