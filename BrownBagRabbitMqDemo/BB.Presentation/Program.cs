using System;
using BB.Infrastructure.Receiver;
using BB.Infrastructure.Sender;

namespace BB.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            var sender = new SendRequest();
            sender.GetMessage();
            var receive = new Receive();
            receive.ReceiveMessage();
            Console.ReadLine();
        }
    }
}
