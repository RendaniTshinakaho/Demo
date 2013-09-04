using System;
using System.Text;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace BB.Infrastructure.Receiver
{
    public class Receive
    {
        public void ReceiveMessage()
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    channel.QueueDeclare("IncomingMessagesReceived", false, false, false, null);

                    var consumer = new QueueingBasicConsumer(channel);
                    channel.BasicConsume("Receiver", true, consumer);

                    Console.WriteLine(" [*] Waiting for messages." +
                                             "To exit press CTRL+C");
                    while (true)
                    {
                        var ea = (BasicDeliverEventArgs)consumer.Queue.Dequeue();

                        var body = ea.Body;
                        var message = Encoding.UTF8.GetString(body);
                        Console.WriteLine(" [x] Received {0}", message);
                    }
                }
            }
        }
    }
}
