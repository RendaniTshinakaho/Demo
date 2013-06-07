using System;
using QuoteServer;

namespace TestQuoteServer
{
    class Program
    {
        static void Main()
        {
            ClsQuoteServer qs = new ClsQuoteServer(@"c:\Quote.txt");
            qs.Start();
            Console.WriteLine("Hit Return to Exit");
            Console.ReadLine();
            qs.Stop();
        }
    }
}
